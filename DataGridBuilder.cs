using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace CBRCurrs
{
    class DataGridBuilder
    {
        public XmlNode _nodes { get; set; }
        public List<List<string>> rows { get; set; }
        public List<string> _columnHeaders { get; set; }
        public DataGridBuilder(XmlNode node)
        {
            _nodes = node;
        }               
        
        public List<List<string>> Build()
        {   
            rows = new List<List<string>>();            
            _columnHeaders = new List<string>();                        
            XmlNode el = _nodes.ChildNodes.Item(0);
                        
            for (int i = 0; i < _nodes.ChildNodes.Count; i += 1)
            {
                XmlNode item = _nodes.ChildNodes.Item(i);
                List<string> cells = new List<string>();
                for (int j = 0; j < item.ChildNodes.Count; j++)
                {
                    cells.Add(item[item.ChildNodes.Item(j).Name].InnerText.TrimEnd());
                    
                }
                rows.Add(cells);
            }

            for (int i = 0; i < el.ChildNodes.Count; i++)
            {
                _columnHeaders.Add(el.ChildNodes.Item(i).Name);
            }

            return rows;
        }
    }
}
