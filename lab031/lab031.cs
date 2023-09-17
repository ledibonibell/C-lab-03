using System;

struct Vector
{
    public double X;
    public double Y;
    public double Z;

    public Vector(double x = 0.0, double y = 0.0, double z = 0.0)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector operator +(Vector left, Vector right)
    {
        return new Vector(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
    }

    public static double operator *(Vector left, Vector right)
    {
        return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
    }

    public static Vector operator *(Vector vector, double scalar)
    {
        return new Vector(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
    }

    public static bool operator <(Vector left, Vector right)
    {
        double length1 = Math.Sqrt(left.X * left.X + left.Y * left.Y + left.Z * left.Z);
        double length2 = Math.Sqrt(right.X * right.X + right.Y * right.Y + right.Z * right.Z);
        return length1 < length2;
    }

    public static bool operator >(Vector left, Vector right)
    {
        double length1 = Math.Sqrt(left.X * left.X + left.Y * left.Y + left.Z * left.Z);
        double length2 = Math.Sqrt(right.X * right.X + right.Y * right.Y + right.Z * right.Z);
        return length1 > length2;
    }

    public static bool operator ==(Vector left, Vector right)
    {
        return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
    }

    public static bool operator !=(Vector left, Vector right)
    {
        return !(left == right);
    }
}

class lab031
{
    static void Main()
    {
        Vector v1 = new Vector(1.0, 2.0, 3.0);
        Vector v2 = new Vector(4.0, 5.0, 6.0);

        Vector sum = v1 + v2;
        double dotProduct = v1 * v2;
        Vector scaled = v1 * 2.0;
        bool comparison = v1 < v2;

        Console.WriteLine($"Sum: ({sum.X}, {sum.Y}, {sum.Z})");
        Console.WriteLine($"Dot Product: {dotProduct}");
        Console.WriteLine($"Scaled: ({scaled.X}, {scaled.Y}, {scaled.Z})");
        Console.WriteLine($"Comparison: {comparison}");

        Vector v3 = new Vector(1.0, 2.0, 3.0);
        bool isEqual = v1 == v3;
        Console.WriteLine($"v1 == v3: {isEqual}");
    }
}
