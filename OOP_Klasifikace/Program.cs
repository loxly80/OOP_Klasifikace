using OOP_Klasifikace;

Student gebel = new Student("Jáchym Gebel");
Student fagulec = new Student("Adam Fagulec");

fagulec.PridatZnamkuProgramko(2);
fagulec.PridatZnamkuAnglictina(1);
fagulec.PridatZnamkuMatika(4);
fagulec.PridatZnamkuCestina(5);
fagulec.PridatZnamkuCestina(1);
gebel.PridatZnamkuCestina(3);
gebel.PridatZnamkuCestina(2);
gebel.PridatZnamkuCestina(4);
gebel.PridatZnamkuCestina(3);
gebel.PridatZnamkuCestina(2);
gebel.PridatZnamkuCestina(1);

Console.WriteLine(gebel);
Console.WriteLine(fagulec);

Console.WriteLine(gebel.PrumerCestina());