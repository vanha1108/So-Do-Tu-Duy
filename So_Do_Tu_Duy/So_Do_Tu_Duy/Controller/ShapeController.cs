using So_Do_Tu_Duy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy.Controller
{
    public class ShapeController
    {
        public static bool AddShape(Shape sp)
        {
            using (var _context = new DBMindMapEntities())
            {
                try
                {
                    _context.Shapes.AddOrUpdate(sp);
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

        public static List<Shape> getListShape(int id)
        {
            using (var _context = new DBMindMapEntities())
            {
                var sh = (from t in _context.Shapes
                          where t.IDPro == id
                          select t).ToList();
                return sh;
            }
        }

        public static List<Shape> getListShape()
        {
            using (var _context = new DBMindMapEntities())
            {
                var sh = (from t in _context.Shapes
                          select t).ToList();
                return sh;
            }
        }

    }
}
