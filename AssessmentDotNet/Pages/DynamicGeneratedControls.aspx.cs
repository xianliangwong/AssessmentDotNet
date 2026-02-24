using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssessmentDotNet.Pages
{
    public partial class DynamicGeneratedControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                GenerateControls();

            }

        }

        protected void btnGenerate_Click(object sender, EventArgs e) 
        { 
            GenerateControls(); 
        }

        private void GenerateControls()
        {


            dynamicContentControls.Controls.Clear();

            string selectedType = ddlControlType.SelectedValue;

            int numberOfControls = 0;

            if(int.TryParse(txtNumber.Text, out numberOfControls)){

                for (int i = 0; i < numberOfControls; i++) 
                {
                    Control newControl = null;

                    switch (selectedType)
                    {
                        case "TextBox": 
                            newControl = new TextBox { ID = "txtDynamicCtrl" + i }; 
                            break;
                        case "CheckBox": 
                            newControl = new CheckBox { ID = "chkDynamicCtrl" + i, Text = "Option " + i }; 
                            break;
                        case "Button": 
                            newControl = new Button { ID = "btnDynamicCtrl" + i, Text = "Button " + i }; 
                            break;

                    }

                    if(newControl != null)
                    {
                        dynamicContentControls.Controls.Add(newControl);
                        //create line break 
                        dynamicContentControls.Controls.Add(new Literal { Text = "<br/>" });
                    }
                
                }

            }





        }
    }
}