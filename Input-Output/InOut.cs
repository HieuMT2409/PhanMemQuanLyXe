using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThueXeOTo.ControlCar;
using ThueXeOTo.Database;
using Excel = Microsoft.Office.Interop.Excel;

namespace ThueXeOTo.Input_Output
{
    public partial class InOut : Form
    {
        public InOut()
        {
            InitializeComponent();

            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var customers = context.Customers.ToList();

                this.data.DataSource = customers;
                this.data.Refresh();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var customers = context.Customers.ToList();

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Customers");

                    //tiêu đề cho cột
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Name";
                    worksheet.Cells[1, 3].Value = "Address";
                    worksheet.Cells[1, 4].Value = "Phone";

                    // Ghi dữ liệu
                    int row = 2;
                    foreach (var customer in customers)
                    {
                        worksheet.Cells[row, 1].Value = customer.ID;
                        worksheet.Cells[row, 2].Value = customer.Name;
                        worksheet.Cells[row, 3].Value = customer.Address;
                        worksheet.Cells[row, 4].Value = customer.SDT;
                        row++;
                    }

                    // định dạng cột tự động
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Save Excel File",
                        FileName = "CustomerData.xlsx"
                    };

                    //Hỏi nơi lưu file Excel
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        package.SaveAs(fileStream);
                        fileStream.Close();
                    }
                }
            }
        }

        public void LoadData()
        {
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var customers = context.Customers.ToList();

                this.data.DataSource = customers;
                this.data.Refresh();
            }
        }

        private void InOut_Load(object sender, EventArgs e)
        {
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var customers = context.Customers.ToList();

                this.data.DataSource = customers;
                this.data.Refresh();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //chọn tập tin
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Car> cars = new List<Car>();
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                try
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        if (package.Workbook.Worksheets.Count > 0)
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                            int rowCount = worksheet.Dimension.Rows;

                            for (int row = 2; row <= rowCount; row++)
                            {
                                Car car = new Car
                                {
                                    ID = int.Parse(worksheet.Cells[row, 1].Text),
                                    Name = worksheet.Cells[row, 2].Text,
                                    Type = worksheet.Cells[row, 3].Text,
                                    State = worksheet.Cells[row, 4].Text,
                                    Company = worksheet.Cells[row, 5].Text,
                                    Price = worksheet.Cells[row, 6].Text
                                };

                                cars.Add(car);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không có worksheet");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                foreach (var car in cars)
                {
                    using (var context = new CarDBContext())
                    {
                        context.AddCar(car.Name, car.Type, car.Company, car.State, car.Price);
                    }
                }

                data.Visible = false;
                datacar.Visible = true;
                datacar.DataSource = cars;
            }
        }

        private void datacar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
