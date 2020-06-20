using So_Do_Tu_Duy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Do_Tu_Duy.Controller
{
    public class ShapeController
    {
        public static bool AddShape(Root root)
        {
            using ( var _context = new DBMindMapEntities() )
            {
                foreach ( var shape in root.lstObj)
                {
                    
                }    
            }    
            return true;
        }
    }
}
