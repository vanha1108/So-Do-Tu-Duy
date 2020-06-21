using So_Do_Tu_Duy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_Do_Tu_Duy.Controller
{
    public class ShapeController
    {
 
        public static bool AddShape(Root root)
        {
            using ( var _context = new DBMindMapEntities() )
            {
                try
                {
                    Shape sp = new Shape();
                    foreach (var shape in root.lstObj)
                    {
                        sp.LocationX = shape.Point.X;
                        sp.LocationY = shape.Point.Y;
                        sp.Witdh = shape.Witdh;
                        sp.Height = shape.Height;
                        sp.Descripton = "test";
                        sp.NameShape = shape.Name;
                        sp.IDPro = 24;
                        _context.Shapes.Add(sp);
                        _context.SaveChanges();                 
                    }
                    return true;
                }
                catch (Exception e) 
                {
                    MessageBox.Show(e.Message);
                    return false; 
                }         
            }    
        }
    }
}
