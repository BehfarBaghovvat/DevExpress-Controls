using System.Linq;
using System.Data.Entity;
using System;

namespace DevExpress_Controls
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		public Models.Producte _entityProducte = new Models.Producte();

		private bool _updateFile = false;

		public MainForm()
		{
			InitializeComponent();



		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			variableLabelControl.Text =
				Infrastructure.Utility.CapacityVariables1();

			addRegionUC1.captionLabel.Text = Infrastructure.Utility.GetRegionName(addRegionUC1.RegionID);

			addRegionUC1.RefreshData();
		}


		private void MainTabPane_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
		{
			if (e.Page.Caption == "ثبت  کالا")
			{
				LoadingProducte();
			}
		}

		private void listVariableNumricTabNavigationPage_Click(object sender, System.EventArgs e)
		{
			variableLabelControl.Text =
				Infrastructure.Utility.CapacityVariables1();
		}

		#region productRegisterTabNavigationPage

		private void ProductNameTextEdit_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void ProductNameTextEdit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		private void ProductNameTextEdit_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productNameTextEdit.Text))
			{
				return;
			}
			else
			{
				_entityProducte.Product_Name = productNameTextEdit.Text;
			}
		}

		private void QuantityTextEdit_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void QuantityTextEdit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		private void QuantityTextEdit_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(quantityTextEdit.Text))
			{
				return;
			}
			else
			{

				if (quantityTextEdit.Text.Contains(','))
				{
					_entityProducte.Quantity = int.Parse(quantityTextEdit.Text.Replace(",", string.Empty).Trim());
					quantityTextEdit.Text = $"{_entityProducte.Quantity:#,0}";
				}
				else
				{
					_entityProducte.Quantity = int.Parse(quantityTextEdit.Text.Replace(",", string.Empty).Trim());
					quantityTextEdit.Text = $"{_entityProducte.Quantity:#,0}";
				}
			}
		}

		private void PriceTextEdit_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void PriceTextEdit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		private void PriceTextEdit_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(priceTextEdit.Text))
			{
				return;
			}
			else
			{
				if (priceTextEdit.Text.Contains("تومان"))
				{
					_entityProducte.Price = long.Parse(priceTextEdit.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					priceTextEdit.Text = $"{_entityProducte.Price:#,0} تومان";
				}
				else
				{
					_entityProducte.Price = long.Parse(priceTextEdit.Text.Trim());

					priceTextEdit.Text = $"{_entityProducte.Price:#,0} تومان";
				}



			}
		}

		private void EntityStatusCheckEdit_CheckedChanged(object sender, System.EventArgs e)
		{
			_entityProducte.Entity_Status = entityStatusCheckEdit.Checked;
		}

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationControls(_entityProducte))
			{
				RegisterProducte(_entityProducte, _updateFile);
			}
		}

		private void NewButton_Click(object sender, System.EventArgs e)
		{
			ResetControls();
		}

		private void DeleteRepository_Click(object sender, System.EventArgs e)
		{
			string producteName = productListGridView.GetFocusedRowCellValue("Product_Name").ToString();//--- مقدار فیلد جاری نام کالا را بر میگرداند

			if (System.Windows.Forms.MessageBox.Show($"آیا از حذف {producteName} مطمئن هستید؟", "", buttons: System.Windows.Forms.MessageBoxButtons.YesNo, icon: System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				DeleteProduct(producteName);
			}
		}

		private void DeactiveRepository_Click(object sender, EventArgs e)
		{
			string producteName = productListGridView.GetFocusedRowCellValue("Product_Name").ToString();//--- مقدار فیلد جاری نام کالا را بر میگرداند

			if (System.Windows.Forms.MessageBox.Show($"آیا از غیر فعال کردن {producteName} مطمئن هستید؟", "", buttons: System.Windows.Forms.MessageBoxButtons.YesNo, icon: System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				ActiveProducte(producteName);
			}
		}


		#endregion /productRegisterTabNavigationPage

		//---------------- Private Methods

		private void ActiveProducte(string producteName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Producte updateProduct
					= dataBaseContext.Productes
					.Where(current => string.Compare(current.Product_Name, producteName) == 0)
					.FirstOrDefault();

				if (updateProduct != null)
				{
					updateProduct.Is_Active = false;
				}

				dataBaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show($"{producteName} غیر فعال گردید.");

				LoadingProducte();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
				throw;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}

		private void DeleteProduct(string producteName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Producte deleteProducte =
					dataBaseContext.Productes
					.FirstOrDefault();

				var entry = dataBaseContext.Entry(deleteProducte);

				if (entry.State == System.Data.Entity.EntityState.Detached)
				{
					dataBaseContext.Productes.Attach(deleteProducte);
				}

				dataBaseContext.Productes.Remove(deleteProducte);
				dataBaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show($"{producteName} از لیست حذف گردید");

				LoadingProducte();

			}
			catch (System.Exception ex)
			{

				throw;
			}
		}

		private void LoadingProducte()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Producte> listProductReceiveds = null;

				listProductReceiveds =
					dataBaseContext.Productes
					.Where(current => current.Is_Active == true)
					.OrderBy(current => current.Product_Name)
					.ToList();

				producteListGridControl.DataSource = listProductReceiveds;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}

		private void RefrashData()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Producte> listProductReceiveds = null;

				listProductReceiveds =
					dataBaseContext.Productes
					.OrderBy(current => current.Product_Name)
					.ToList();

				producteListGridControl.DataSource = listProductReceiveds;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}

		private void RegisterProducte(Models.Producte producte, bool updateFile)
		{
			Models.DataBaseContext dataBaseContext = null;


			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Producte newProduct
					= dataBaseContext.Productes
					.Where(current => string.Compare(current.Product_Name, producte.Product_Name) == 0)
					.FirstOrDefault();

				if (!updateFile)
				{
					if (newProduct != null)//--> یعنی کالا در سیستم موجود می باشد!
					{
						System.Windows.Forms.MessageBox.Show("کالای ثبت شده در سیستم موجود می باشد.");
						productNameTextEdit.Focus();
						return;
					}
					else
					{


						newProduct = new Models.Producte
						{
							Is_Active = true,
							Product_Name = producte.Product_Name,
							Quantity = producte.Quantity,
							Price = producte.Price,
							Entity_Status = producte.Entity_Status,
							DateTime_Register = System.DateTime.Now,
						};

						dataBaseContext.Productes.Add(newProduct);
						dataBaseContext.SaveChanges();

						System.Windows.Forms.MessageBox.Show("ثبت کالا با موفقیت انجام گردید.");

						LoadingProducte();

						ResetControls();
					}
				}
				else
				{
					newProduct.Is_Active = true;
					newProduct.Product_Name = producte.Product_Name;
					newProduct.Quantity = producte.Quantity;
					newProduct.Price = producte.Price;
					newProduct.Entity_Status = producte.Entity_Status;
					newProduct.DateTime_Register = System.DateTime.Now;

					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show("ثبت کالا با به روز رسانی شد انجام گردید.");

					LoadingProducte();

					ResetControls();

					_updateFile = false;
				}


			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
				throw;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}




		}

		public void ResetControls()
		{
			productNameTextEdit.Text = string.Empty;
			quantityTextEdit.Text = string.Empty;
			priceTextEdit.Text = string.Empty;
			entityStatusCheckEdit.Checked = false;
			selectAllCheckEdit.Checked = false;
			registerButton.Text = "ثبت کالا";
		}

		public bool ValidationControls(Models.Producte producte)
		{
			string errorMessage = null;

			try
			{
				if (string.IsNullOrEmpty(producte.Product_Name))
				{
					errorMessage = "لطفا نام کالا را وارد نمایید.";
				}
				if (string.IsNullOrEmpty(producte.Quantity.ToString()))
				{
					if (!string.IsNullOrEmpty(errorMessage))
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage += "لطفا تعداد کالا را وارد نمایید.";
				}
				if (string.IsNullOrEmpty(producte.Price.ToString()))
				{
					if (!string.IsNullOrEmpty(errorMessage))
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage += "لطفا قیمت کالا را وارد نمایید.";
				}


				if (string.IsNullOrEmpty(errorMessage))
				{
					return true;
				}
				else
				{

					System.Windows.Forms.MessageBox.Show(errorMessage, "نقص در اطلاعات", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);

					if (string.IsNullOrEmpty(producte.Product_Name))
					{
						productNameTextEdit.Focus();
					}
					else if (string.IsNullOrEmpty(producte.Quantity.ToString()))
					{
						quantityTextEdit.Focus();
					}
					else if (string.IsNullOrEmpty(producte.Price.ToString()))
					{
						priceTextEdit.Focus();
					}
					return false;
				}
			}
			catch (System.Exception ex)
			{

				System.Windows.Forms.MessageBox.Show(ex.Message);
				return false;

			}
		}

		private void ProductListGridView_DoubleClick(object sender, EventArgs e)
		{
			productNameTextEdit.Text = productListGridView.GetFocusedRowCellValue("Product_Name").ToString();
			quantityTextEdit.Text = productListGridView.GetFocusedRowCellValue("Quantity").ToString();
			priceTextEdit.Text = productListGridView.GetFocusedRowCellValue("Price").ToString();

			registerButton.Text = "به روز رسانی";

			_updateFile = true;
		}
	}
}
