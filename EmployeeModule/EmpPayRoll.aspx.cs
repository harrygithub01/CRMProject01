using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace CRMAPP1.EmployeeModule
{
	/// <summary>
	/// Summary description for EmpPayRoll.
	/// </summary>
	public class EmpPayRoll : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.RangeValidator RangeValidator1;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("..//EmployeeModule/EmpMain.aspx");
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{			
			SqlConnection con=new SqlConnection ("server=.;database=crm;uid=sa;pwd=;");
			SqlDataAdapter apt=new SqlDataAdapter("select * from  crm_emppayroll where empid='"+TextBox1.Text+"'",con);
			DataSet ds =new DataSet();
			apt.Fill(ds);
			DataGrid1.DataSource=ds;
			DataGrid1.DataBind();
		
		}
	}
}

