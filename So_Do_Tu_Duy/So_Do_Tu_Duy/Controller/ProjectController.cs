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
                    MessageBox.Show("Đã lưu xuống DB!");
                    _context.ProjectShapes.AddOrUpdate(project);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                //catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                //{
                //    Exception raise = dbEx;
                //    foreach (var validationErrors in dbEx.EntityValidationErrors)
                //    {
                //        foreach (var validationError in validationErrors.ValidationErrors)
                //        {
                //            string message = string.Format("{0}:{1}",
                //                validationErrors.Entry.Entity.ToString(),
                //                validationError.ErrorMessage);
                //            // raise a new exception nesting  
                //            // the current instance as InnerException  
                //            raise = new InvalidOperationException(message, raise);
                //        }
                //    }
                //    throw raise;
                //}
            }    
        }

        public static string getInforProject()
        {
            using ( var _context = new DBMindMapEntities() )
            {
                var nt = (from t in _context.ProjectShapes
                          select t.note).ToList();
                return nt[0];
            }    
        }
    }
}
