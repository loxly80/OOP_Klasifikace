using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klasifikace
{
  public class Student
  {
    private string jmeno;
    private List<int> cestina = new List<int>();
    private List<int> anglictina = new List<int>();
    private List<int> matika = new List<int>();
    private List<int> programko = new List<int>();

    public Student(string jmeno)
    {
      this.jmeno = jmeno;
    }

    public void PridatZnamkuCestina(int znamka)
    {
      cestina.Add(znamka);
    }

    public void PridatZnamkuAnglictina(int znamka)
    {
      anglictina.Add(znamka);
    }

    public void PridatZnamkuMatika(int znamka)
    {
      matika.Add(znamka);
    }

    public void PridatZnamkuProgramko(int znamka)
    {
      programko.Add(znamka);
    }

    public double PrumerCestina()
    {
      return cestina.Average();
    }

    public double PrumerAnglictina()
    {
      return anglictina.Average();
    }

    public double PrumerMatika()
    {
      return matika.Average();
    }

    public double PrumerProgramko()
    {
      return programko.Average();
    }

    public override string ToString()
    {
      string text = jmeno + "\r\n";
      if(cestina.Count > 0)
      {
        text += "ČJ:  " + string.Join("; ", cestina) + " - " + PrumerCestina() + "\r\n";
      }
      else
      {
        text += "ČJ: \r\n";
      }
      if (matika.Count > 0)
      {
        text += "M:   " + string.Join("; ", matika) + " - " + PrumerMatika() + "\r\n";
      }
      else
      {
        text += "M: \r\n";
      }
      if (anglictina.Count > 0)
      {
        text += "AJ:  " + string.Join("; ", anglictina) + " - " + PrumerAnglictina() + "\r\n";
      }
      else
      {
        text += "AJ: \r\n";
      }
      if (programko.Count > 0)
      {
        text += "PRG: " + string.Join("; ", programko) + " - " + PrumerProgramko() + "\r\n";
      }
      else
      {
        text += "PRG: \r\n";
      }
      return text;
    }
  }
}
