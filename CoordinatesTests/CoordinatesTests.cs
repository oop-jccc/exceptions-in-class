namespace CoordinatesTests;

public record Coordinates
{
    public double Latitude { get; }
    public double Longitude { get; }

    public Coordinates(double latitude, double longitude)
    {
        if (latitude is > 90 or < -90)
        {
            throw new ArgumentException("Latitude should be between -90 and 90");
        }

        Latitude = latitude;

        if (longitude is > 180 or < -180)
        {
            throw new ArgumentException("Longitude should be between -180 and 180");
        }

        Longitude = longitude;
    }
}

[TestFixture]
public class CoordinatesTests
{
    [Test]
    public void TestValidCoordinates()
    {
        var coordinates = new Coordinates(45.0, 90.0);
        Assert.That(coordinates.Latitude, Is.EqualTo(45.0));
        Assert.That(coordinates.Longitude, Is.EqualTo(90.0));
    }

    [Test]
    public void TestInvalidLatitudeThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Coordinates(91.0, 90.0));
    }

    [Test]
    public void TestInvalidLongitudeThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Coordinates(45.0, 181.0));
    }

    [Test]
    public void TestNegativeInvalidLatitudeThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Coordinates(-91.0, 90.0));
    }

    [Test]
    public void TestNegativeInvalidLongitudeThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Coordinates(45.0, -181.0));
    }
}