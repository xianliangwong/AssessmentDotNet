using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssessmentDotNet.Pages
{
    public partial class EmployeePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { BindGrid(); }

        }

        private void BindGrid() 
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                string query = @" SELECT employee_no, employee_name, birth_date FROM employee_biodata WHERE (employee_name LIKE 'A%' OR employee_name LIKE 'G%' OR employee_name LIKE 'V%') AND (MONTH(birth_date) BETWEEN 1 AND 3)"; 
                SqlDataAdapter da = new SqlDataAdapter(query, connection); 
                DataTable dt = new DataTable(); 
                da.Fill(dt); 
                GridView1.DataSource = dt; 
                GridView1.DataBind();

            }
        
        }
    }
}