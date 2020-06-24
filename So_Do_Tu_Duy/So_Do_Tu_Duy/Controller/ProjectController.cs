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

        public static ProjectShape getProject(int id)
        {
            using (var _context = new DBMindMapEntities())
            {
                var pr = (from t in _context.ProjectShapes
                          where t.IDPro == id
                          select t).SingleOrDefault();
                return pr;
            }
        }

        public static List<ProjectShape> getListProject(int id)
        {
            using (var _context = new DBMindMapEntities())
            {
                var pr = (from t in _context.ProjectShapes
                          where t.IDPro == id
                          select t).ToList();
                return pr;
            }
        }

        public static List<ProjectShape> getListProject()
        {
            using ( var _context = new DBMindMapEntities() )
            {
                var pr = (from t in _context.ProjectShapes
                          select t).ToList();
                return pr;
            }    
        }

        public static bool DeleteProject(int id)
        {
            using ( var _context = new DBMindMapEntities() )
            {
                try
                {
                    var lstidShape = (from t in _context.Shapes
                               where t.IDPro == id
                               select t.ID).ToList();

                    foreach ( var x in lstidShape )
                    {
                        var infor = (from z in _context.Infors
                                   where z.ID == x
                                   select z).SingleOrDefault();
                        if ( infor != null)
                        {
                            _context.Infors.Remove(infor);
                        }    
                    }
                    
                    foreach ( var x in lstidShape )
                    {
                        var sh = (from s in _context.Shapes
                                  where s.ID == x
                                  select s).SingleOrDefault();
                        _context.Shapes.Remove(sh);
                    }

                    var pr = (from q in _context.ProjectShapes
                              where q.IDPro == id
                              select q).SingleOrDefault();
                    _context.ProjectShapes.Remove(pr);
                    _context.SaveChanges();
                    return false;

                } catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }    
        }
    }
}
