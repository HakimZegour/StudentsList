using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentsList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            GridView1.DataSource = from etudiant in dataContext.StudentsTables
                                   where etudiant.Classe == "troisieme"
                                   select etudiant;
            GridView1.DataBind();
        }
    }
}