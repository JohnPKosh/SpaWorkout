using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace react1.Models
{
  public class Skill
  {
    public Skill(string name, SkillStrength strength)
    {
      Name = name;
      Strength = strength;
    }

    public string Name { get; set; }

    public SkillStrength Strength { get; set; }
  }

  public enum SkillStrength
  {
    Basic,
    Proficient,
    Expert
  }
}
