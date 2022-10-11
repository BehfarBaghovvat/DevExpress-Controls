using System.Linq;
using System.Data.Entity;
using System;

namespace DevExpress_Controls
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		Models.DataBaseContext dataBaseContext = new Models.DataBaseContext();
		


		public Models.Producte _entityProducte = new Models.Producte();

		private Models.Location _location;

		public Models.Location MyLocation
		{
			get 
			{
				if (_location == null)
				{
					_location =
						new Models.Location();
				}
				return _location;
			}
			set 
			{ 
				_location = value;
			}
		}

		private Models.AccountParty _accountParty;

		public Models.AccountParty AccountParty
		{
			get
			{
				if (_accountParty == null)
				{
					_accountParty =
						new Models.AccountParty();
				}

				return _accountParty;

			}

			set
			{
				_accountParty = value;
			}
		}



		private bool _updateFile = false;



		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			variableLabelControl.Text =
				Infrastructure.Utility.CapacityVariables1();

			countryRegionUC.captionLabel.Text = Infrastructure.Utility.GetRegionName(countryRegionUC.RegionID);

			countryRegionUC.RefreshData();

			stateRegionUC.captionLabel.Text = Infrastructure.Utility.GetRegionName(stateRegionUC.RegionID);

			stateRegionUC.RefreshData();

			cityRegionUC.captionLabel.Text = Infrastructure.Utility.GetRegionName(cityRegionUC.RegionID);

			cityRegionUC.RefreshData();

			areaRegionUC.captionLabel.Text = Infrastructure.Utility.GetRegionName(areaRegionUC.RegionID);

			areaRegionUC.RefreshData();

		}


		private void MainTabPane_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
		{
			if (e.Page.Caption == "ثبت  کالا")
			{
				LoadingProducte();
			}

			if (e.Page.Caption == "مشتری")
			{
				GetLocationData();
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
			if (ValidationProducte(_entityProducte))
			{
				RegisterProducte(_entityProducte, _updateFile);
			}
		}

		private void NewButton_Click(object sender, System.EventArgs e)
		{
			ResetControls();
		}

		private void ProductListGridView_DoubleClick(object sender, EventArgs e)
		{
			productNameTextEdit.Text = productListGridView.GetFocusedRowCellValue("Product_Name").ToString();
			quantityTextEdit.Text = productListGridView.GetFocusedRowCellValue("Quantity").ToString();
			priceTextEdit.Text = productListGridView.GetFocusedRowCellValue("Price").ToString();

			registerButton.Text = "به روز رسانی";

			_updateFile = true;
		}

		private void DeleteRepository_Click(object sender, System.EventArgs e)
		{
			string producteName = productListGridView.GetFocusedRowCellValue("Product_Name").ToString();//--- مقدار نام کالا در فیلد جاری را بر میگرداند

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


		#region customerTabNavigationPage


		private void GetAddressSimpleButton_Click(object sender, EventArgs e)
		{
			countryTextEdit.Text = locationLookUpEdit.GetColumnValue("Country_Name").ToString();
			stateTextEdit.Text = locationLookUpEdit.GetColumnValue("State_Name").ToString();
			cityTextEdit.Text = locationLookUpEdit.GetColumnValue("City_Name").ToString();
			areaTextEdit.Text = locationLookUpEdit.GetColumnValue("Area_Name").ToString();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (ValiddationAccountParty(AccountParty))
			{
				RegisterAccountParty(AccountParty);
			}
		}

		private void RegisterAccountParty(Models.AccountParty accountParty)
		{

			try
			{
				dataBaseContext =
						new Models.DataBaseContext();

				Models.AccountParty addAccountParty
					= dataBaseContext.AccountParties
					.FirstOrDefault();

				addAccountParty =
					new Models.AccountParty()
					{
						FullName = accountParty.FullName,
						Account_Type = accountParty.Account_Type,
						Mobile = accountParty.Mobile,
						Phone = accountParty.Phone,
						Address = accountParty.Address,
					};

				dataBaseContext.AccountParties.Add(addAccountParty);
				dataBaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Test");


			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				dataBaseContext = null;
				dataBaseContext.Dispose();
			}






		}


		#endregion /customerTabNavigationPage


		#region registerPositionTabNavigationPage

		private void CountryRegionUC_Leave(object sender, EventArgs e)
		{
			if (countryRegionUC.regionNameCheckedListBoxControl.CheckedItems.Count == 0)
			{
				countryRegionUC.MyRegion = null;

				stateRegionUC.MyRegion.Region_Id = 0;
			}
			else
			{
				stateRegionUC.MyRegion.Region_Id = countryRegionUC.RegionID;
			}
		}

		private void CountryRegionUC_SelectItem(object sender, EventArgs e)
		{
			if (countryRegionUC.regionNameCheckedListBoxControl.GetItemChecked(countryRegionUC.regionNameCheckedListBoxControl.SelectedIndex))
			{
				MyLocation.Country_Name = $"{countryRegionUC.GetSelectItemValue()}, ";

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
			else
			{
				MyLocation.Country_Name = null;

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
		}

		private void StateRegionUC_Enter(object sender, EventArgs e)
		{
			

			if (stateRegionUC.MyRegion.Region_Id == 1)
			{
				stateRegionUC.MyRegion = countryRegionUC.MyRegion;
			}
			else
			{
				return;
			}
		}

		private void StateRegionUC_Leave(object sender, EventArgs e)
		{
			if (stateRegionUC.regionNameCheckedListBoxControl.CheckedItems.Count == 0)
			{
				cityRegionUC.MyRegion = null;

				cityRegionUC.MyRegion.Region_Id = 0;
			}
			else
			{
				cityRegionUC.MyRegion.Region_Id = stateRegionUC.RegionID;
			}
		}

		private void StateRegionUC_SelectItem(object sender, EventArgs e)
		{
			stateRegionUC.OldValue = stateRegionUC.GetSelectItemValue();
			stateRegionUC.InputValue = stateRegionUC.GetSelectItemValue();

			if (stateRegionUC.regionNameCheckedListBoxControl.GetItemChecked(stateRegionUC.regionNameCheckedListBoxControl.SelectedIndex))
			{
				MyLocation.State_Name = $"{stateRegionUC.GetSelectItemValue()}, ";

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
			else
			{
				MyLocation.State_Name = null;

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
		}

		private void CityRegionUC_Enter(object sender, EventArgs e)
		{
			if (cityRegionUC.MyRegion.Region_Id == 2)
			{
				cityRegionUC.MyRegion = stateRegionUC.MyRegion;
			}
			else
			{
				return;
			}
		}

		private void CityRegionUC_Leave(object sender, EventArgs e)
		{
			if (cityRegionUC.regionNameCheckedListBoxControl.CheckedItems.Count == 0)
			{
				areaRegionUC.MyRegion = null;
				areaRegionUC.MyRegion.Region_Id = 0;
			}
			else
			{
				areaRegionUC.MyRegion.Region_Id = cityRegionUC.RegionID;
			}
		}

		private void CityRegionUC_SelectItem(object sender, EventArgs e)
		{
			cityRegionUC.OldValue = cityRegionUC.GetSelectItemValue();
			cityRegionUC.InputValue = cityRegionUC.GetSelectItemValue();

			if (cityRegionUC.regionNameCheckedListBoxControl.GetItemChecked(cityRegionUC.regionNameCheckedListBoxControl.SelectedIndex))
			{
				MyLocation.City_Name = $"{cityRegionUC.GetSelectItemValue()}, ";

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
			else
			{
				MyLocation.City_Name = null;

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
		}

		private void AreaRegionUC_Enter(object sender, EventArgs e)
		{

			if (areaRegionUC.MyRegion.Region_Id == 3)
			{
				areaRegionUC.MyRegion = cityRegionUC.MyRegion;
			}
			else
			{
				return;
			}
		}

		private void AreaRegionUC_SelectItem(object sender, EventArgs e)
		{
			areaRegionUC.OldValue = areaRegionUC.GetSelectItemValue();
			areaRegionUC.InputValue = areaRegionUC.GetSelectItemValue();

			if (areaRegionUC.regionNameCheckedListBoxControl.GetItemChecked(areaRegionUC.regionNameCheckedListBoxControl.SelectedIndex))
			{
				MyLocation.Area_Name = $"{areaRegionUC.GetSelectItemValue()}";

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
			else
			{
				MyLocation.Area_Name = null;

				previewAddressTextEdit.Text = $"{MyLocation.Country_Name}{MyLocation.State_Name}{MyLocation.City_Name}{MyLocation.Area_Name}";
			}
		}

		private void AreaResidenceButton_Click(object sender, EventArgs e)
		{
			SetLocationClient(MyLocation);
		}

		#endregion /registerPositionTabNavigationPage



		






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

		private bool ValiddationAccountParty(Models.AccountParty accountParty)
		{
			string errorMessage = null;

			try
			{
				if (string.IsNullOrEmpty(accountParty.FullName))
				{
					errorMessage = "لطفا نام طرف حساب را وارد نمایید.";
				}
				if (string.IsNullOrEmpty(accountParty.Mobile.ToString()) && string.IsNullOrWhiteSpace(accountParty.Phone.ToString()))
				{
					if (!string.IsNullOrEmpty(errorMessage))
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage += "لطفا یک شماره تماس وارد نمایید.";
				}
				if (string.IsNullOrEmpty(accountParty.Account_Type.ToString()))
				{
					if (!string.IsNullOrEmpty(errorMessage))
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage += "لطفا نوع طرف حساب را وارد نمایید.";
				}
				if (string.IsNullOrEmpty(accountParty.Address.ToString()))
				{
					if (!string.IsNullOrEmpty(errorMessage))
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage += "لطفا آدرس را وارد نمایید.";
				}


				if (string.IsNullOrEmpty(errorMessage))
				{
					return true;
				}
				else
				{

					System.Windows.Forms.MessageBox.Show(errorMessage, "نقص در اطلاعات", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);

					if (string.IsNullOrEmpty(accountParty.FullName))
					{
						productNameTextEdit.Focus();
					}
					else if (string.IsNullOrEmpty(accountParty.Mobile.ToString()) && string.IsNullOrWhiteSpace(accountParty.Phone.ToString()))
					{
						telephonTextEdit.Focus();
					}
					else if (string.IsNullOrEmpty(accountParty.Account_Type.ToString()))
					{
						purdhaserCheckEdit.Focus();
					}
					else if (string.IsNullOrEmpty(accountParty.Address.ToString()))
					{
						addressTextEdit.Focus();
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

		private bool ValidationProducte(Models.Producte producte)
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

		public void SetLocationClient(Models.Location location)
		{
			Models.DataBaseContext dataBaseContext = null;

			int count = 0;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Location> listLocation = new System.Collections.Generic.List<Models.Location>();

				if (listLocation != null)
				{
					count = 0;
				}
				else
				{
					count = listLocation.Count;
				}

				var newLocation = new Models.Location
				{
					Country_Name = location.Country_Name.Replace(",",String.Empty).Trim(),
					State_Name = location.State_Name.Replace(",", String.Empty).Trim(),
					City_Name = location.City_Name.Replace(",", String.Empty).Trim(), 
					Area_Name = location.Area_Name.Replace(",", String.Empty).Trim(),
				};

				dataBaseContext.Locations.Add(newLocation);
				dataBaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("آدرس ذخیره گردید!");

				previewAddressTextEdit.ResetText();

			}
			catch (Exception)
			{

				throw;
			}
		}

		public void GetLocationData()
		{
			System.Collections.Generic.List<Models.Location> listLocation = new System.Collections.Generic.List<Models.Location>();		

			listLocation =
				dataBaseContext.Locations
				.OrderBy(current => current.Id)
				.ToList();


			locationLookUpEdit.Properties.DataSource = listLocation.Select(current => new { current.Country_Name, current.State_Name, current.City_Name, current.Area_Name});
		}

		private void customerTabNavigationPage_Click(object sender, EventArgs e)
		{
			
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			
		}
	}
}
