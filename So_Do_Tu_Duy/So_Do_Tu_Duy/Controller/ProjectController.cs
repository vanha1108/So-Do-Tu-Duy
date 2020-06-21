using So_Do_Tu_Duy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy.Controller
{
    public class ProjectController
    {
        public static bool AddProject(ProjectShape project)
        {
            using ( var _context = new DBMindMapEntities() )
            {
                try
                {
                    //MessageBox.Show("Successful!!");
                    _context.ProjectShapes.AddOrUpdate(project);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }          
            }    
        }

        public static string getInforProject()
        {
            using ( var _context = new DBMindMapEntities() )
            {
                var nt = (from t in _context.ProjectShapes
                          select t.Note).ToList();
                return nt[0];
            }    
        }
    }
}
