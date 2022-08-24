using SkillBox_HW_Theme_6.Handling;

//UI ui = new UI();
//ui.InputPath();
//ui.Read();
Calculate calculate = new Calculate(10);

int[][] groups = calculate.GroupOfIndivisibles(10);

Transform.JaggedArrayToString(groups);