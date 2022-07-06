using RecordIt;


var employee1 = new Employee(1, "Bukayo", "Saka", 20);
var employee2 = new Employee(1, "Bukayo", "Saka", 20);
Console.WriteLine(employee1.ToString()); //Beautiful ToString()

//All the values are same in employee1 and emplyee2, what will the equality generate?
var result1 = employee1 == employee2;
Console.WriteLine("Is employee1 same as employee2?" + result1);

var admin1 = new Admin(4, "Mikel", "Arteta", 40, "Managerial");
var developer1 = new Developer(4, "Mikel", "Arteta", 40, "Managerial");
var developer2 = new Developer(4, "Mikel", "Arteta", 40, "Managerial");

//All the values are same in admin1 and developer1, what will the equality generate?
var result2 = admin1 == developer1;
Console.WriteLine("Is admin1 same as develper1?" + result2);

var admin2 = admin1;
var result3 = admin1 == admin2;
Console.WriteLine("Is admin1 same as admin2?" + result3);

var admin3 = admin1 with { Department = "Coach"};
var result4 = admin1 == admin3;
Console.WriteLine("Is admin1 same as admin3?" + result4);


Console.ReadLine();



