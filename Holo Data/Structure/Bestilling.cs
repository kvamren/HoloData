using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holo_Data.Structure
{
    class Bestilling
    {
        internal Mottaker parent;

        internal int koli;
        internal int fraktnr;
        internal string sender;
        internal string mottakerpers;
        internal DateTime sendt;

        internal TreeNode GetNode()
        {
            return new TreeNode(sender + " til " + mottakerpers + " antall: " + koli + " av " + fraktnr + " sendt: " + GetDateString());
        }

        internal string GetDateString()
        {
            return sendt.Hour + ":" + sendt.Minute + " " + sendt.Day + "." + sendt.Month.ToString().PadLeft(2,'0') + "." + sendt.Year.ToString().Substring(2);
        }

        internal void Save(System.IO.BinaryWriter bw)
        {
            bw.Write(koli);
            bw.Write(fraktnr);
            bw.Write(sender);
            bw.Write(mottakerpers);
            bw.Write(sendt.ToString());
        }

        internal static Bestilling Load(System.IO.BinaryReader br)
        {
            Bestilling best = new Bestilling();
            best.koli = br.ReadInt32();
            best.fraktnr = br.ReadInt32();
            best.sender = br.ReadString();
            best.mottakerpers = br.ReadString();
            best.sendt = DateTime.Parse(br.ReadString());
            return best;
        }
    }
}
