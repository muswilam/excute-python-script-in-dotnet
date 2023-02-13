using IronPython.Hosting;

// create instance of python engine.
var engine = Python.CreateEngine();

// reading code from file.
var source = engine.CreateScriptSourceFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "calculator.py"));
var scope = engine.CreateScope();

// executing script in scope.
source.Execute(scope);

// get the value stored in scope.
var classCalculator = scope.GetVariable("calculator");

// initializing the class.
var calculatorInstance = engine.Operations.CreateInstance(classCalculator);

Console.WriteLine("Python: ");
Console.WriteLine($"5 + 10 = {calculatorInstance.add(5, 10)}");
Console.WriteLine($"5++ = {calculatorInstance.increment(5)}");