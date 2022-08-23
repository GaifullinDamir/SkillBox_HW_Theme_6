using SkillBox_HW_Theme_6.UI;
using SkillBox_HW_Theme_6.Service;

//UI ui = new UI();
//ui.InputPath();
//ui.Read();
Calculate calculate = new Calculate(10);

int[][] groups = calculate.Processing(10);

Transform.JaggedArrayToString(groups);