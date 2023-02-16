// See https://aka.ms/new-console-template for more information



using praca_s_file;

string file_path = "..\\..\\..\\Resources\\f1_drivers_points.csv";
string save_file_path = "..\\..\\..\\driver_results.txt";

DriverStats driver = new DriverStats();
driver.SaveTxt(file_path);