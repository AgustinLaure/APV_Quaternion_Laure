using CustomMath;
using UnityEngine;

public class Mat4x4
{
    private float m00;
    private float m01;
    private float m02;
    private float m03;

    private float m10;
    private float m11;
    private float m12;
    private float m13;

    private float m20;
    private float m21;
    private float m22;
    private float m23;

    private float m30;
    private float m31;
    private float m32;
    private float m33;

    #region Constructors

    public Mat4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
    {
        m00 = column0.x;
        m01 = column1.x;
        m02 = column2.x;
        m03 = column3.x;

        m10 = column0.y;
        m11 = column1.y;
        m12 = column2.y;
        m13 = column3.y;

        m20 = column0.z;
        m21 = column1.z;
        m22 = column2.z;
        m23 = column3.z;

        m30 = column0.w;
        m31 = column1.w;
        m32 = column2.w;
        m33 = column3.w;
    }

    public Mat4x4(Mat4x4 matrix)
    {
        this.m00 = matrix.m00;
        this.m01 = matrix.m01;
        this.m02 = matrix.m02;
        this.m03 = matrix.m03;

        this.m10 = matrix.m10;
        this.m11 = matrix.m11;
        this.m12 = matrix.m12;
        this.m13 = matrix.m13;

        this.m20 = matrix.m20;
        this.m21 = matrix.m21;
        this.m22 = matrix.m22;
        this.m23 = matrix.m23;

        this.m30 = matrix.m30;
        this.m31 = matrix.m31;
        this.m32 = matrix.m32;
        this.m33 = matrix.m33;
    }

    public Mat4x4(Matrix4x4 unityMatrix)
    {
        this.m00 = unityMatrix.m00;
        this.m01 = unityMatrix.m01;
        this.m02 = unityMatrix.m02;
        this.m03 = unityMatrix.m03;

        this.m10 = unityMatrix.m10;
        this.m11 = unityMatrix.m11;
        this.m12 = unityMatrix.m12;
        this.m13 = unityMatrix.m13;

        this.m20 = unityMatrix.m20;
        this.m21 = unityMatrix.m21;
        this.m22 = unityMatrix.m22;
        this.m23 = unityMatrix.m23;

        this.m30 = unityMatrix.m30;
        this.m31 = unityMatrix.m31;
        this.m32 = unityMatrix.m32;
        this.m33 = unityMatrix.m33;
    }

    #endregion

    #region Properties

    public static Mat4x4 zero
    {
        get
        {
            return new Mat4x4(new Vector4(0f, 0f, 0f, 0f), new Vector4(0f, 0f, 0f, 0f), new Vector4(0f, 0f, 0f, 0f), new Vector4(0f, 0f, 0f, 0f));
        }
    }

    public static Mat4x4 identity
    {
        get
        {
            return Mat4x4.zero; //ni
        }
    }

    public Mat4x4 inverse
    {
        get
        {
            return Mat4x4.zero; //ni
        }
    }

    public float determinant
    {
        get
        {
            return 0f; //ni
        }
    }

    public bool isIdentity
    {
        get
        {
            return false; //ni
        }
    }

    public Quat rotation
    {
        get
        {
            return Quat.identity; //ni
        }
    }

    public Vec3 lossyScale
    {
        get
        {
            return Vec3.Zero;  //ni
        }
    }

    public Vec3 transpose
    {
        get
        {
            return Vec3.Zero; //ni
        }
    }

    #endregion

    #region Operators

    public static Mat4x4 operator *(Mat4x4 lhs, Vector4 vector)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 operator *(Mat4x4 lhs, Mat4x4 rhs)
    {
        return Mat4x4.zero; //ni
    }

    public static bool operator ==(Mat4x4 lhs, Mat4x4 rhs)
    {
        return false; //ni
    }

    public static bool operator !=(Mat4x4 lhs, Mat4x4 rhs)
    {
        return !(lhs == rhs);
    }

    public static implicit operator Matrix4x4(Mat4x4 matrix)
    {
        return new Matrix4x4
            (
            new Vector4
            (
                matrix.m00,
                matrix.m10,
                matrix.m20,
                matrix.m30
            ),
            new Vector4
            (
                matrix.m01,
                matrix.m11,
                matrix.m21,
                matrix.m31
            ),
            new Vector4
            (
                matrix.m02,
                matrix.m12,
                matrix.m22,
                matrix.m32
            ),
            new Vector4
            (
                matrix.m03,
                matrix.m13,
                matrix.m23,
                matrix.m33
            )
            );
    }

    public static implicit operator Mat4x4(Matrix4x4 unityMatrix)
    {
        return new Mat4x4(unityMatrix);
    }

    #endregion

    #region Statics

    public static float Determinant(Mat4x4 m)
    {
        return 0f; //ni
    }

    public static Mat4x4 Inverse(Mat4x4 m)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 LookAt(Vec3 from, Vec3 to, Vec3 up)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 Rotate(Quat q)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 Scale(Vec3 vector)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 Translate(Vec3 vector)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 Transpose(Mat4x4 m)
    {
        return Mat4x4.zero; //ni
    }

    public static Mat4x4 TRS(Vec3 pos, Quat q, Vec3 s)
    {
        return Mat4x4.zero; //ni
    }

    #endregion

    #region Instance

    public Vec3 GetPosition()
    {
        return Vec3.Zero; //ni
    }

    public Vector4 GetRow(int index)
    {
        return Vector4.zero; //ni
    }

    public Vec3 MultiplyPoint(Vec3 point)
    {
        return Vec3.Zero; //ni
    }

    public Vec3 MultiplyPoint3x4(Vec3 point)
    {
        return Vec3.Zero; //ni
    }

    public Vec3 MultiplyVector(Vec3 vector)
    {
        return Vec3.Zero; //ni
    }

    public void SetColumn(int index, Vector4 column)
    {
        //ni
    }

    public void SetRow(int index, Vector4 row)
    {
        //ni
    }

    public void SetTRS(Vec3 pos, Quat q, Vec3 s)
    {
        //ni
    }

    public bool ValidTRS()
    {
        return false; //ni
    }

    public string ToString()
    {
        return " "; //ni
    }

    #endregion
}
