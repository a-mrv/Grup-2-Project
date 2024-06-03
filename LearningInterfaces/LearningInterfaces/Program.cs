using LearningInterfaces.Concrete;

Rectangle rectangle = new();

rectangle.SideA = 5;
rectangle.SideB = 10;

decimal rectangleArea= rectangle.CalculateArea();
decimal rectanglePrimeter = rectangle.CalculatePerimeter();

Circle circle = new ();
circle.Radius = 10;

decimal circleArea = circle.CalculateArea();
decimal circlePerimeter= circle.CalculatePerimeter();

Console.WriteLine(circleArea);
Console.WriteLine(rectangleArea);
Console.WriteLine(circlePerimeter);
Console.WriteLine(rectanglePrimeter);
