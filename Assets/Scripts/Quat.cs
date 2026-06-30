using CustomMath;
using System;
using UnityEngine;
//hacer iquatable & ienumarator
public struct Quat
{
    private float x;
    private float y;
    private float z;
    private float w;

    private const float epsilon = 1E-05f;

    #region Constructors

    public Quat(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public Quat(Quat quat)
    {
        this.x = quat.x;
        this.y = quat.y;
        this.z = quat.z;
        this.w = quat.w;
    }

    #endregion

    public Quat(Quaternion unityQuat)
    {
        this.x = unityQuat.x;
        this.y = unityQuat.y;
        this.z = unityQuat.z;
        this.w = unityQuat.w;
    }

    #region Operators

    public static bool operator ==(Quat lhs, Quat rhs)
    {
        float xDiff = lhs.x - rhs.x;
        float yDiff = lhs.y - rhs.y;
        float zDiff = lhs.z - rhs.z;
        float wDiff = lhs.w - rhs.w;

        return xDiff * xDiff + yDiff * yDiff + zDiff * zDiff + wDiff * wDiff < epsilon * epsilon;
    }

    public static bool operator !=(Quat lhs, Quat rhs)
    {
        return !(lhs == rhs);
    }

    public static Quat operator *(Quat rotation, Vec3 point)
    {
        return Quat.identity; //notImplemented
    }

    public static Quat operator *(Quat lhs, Quat rhs)
    {
        return Quat.identity;  //notImplemented
    }

    public static implicit operator Quaternion(Quat myQuat)
    {
        return new Quaternion(myQuat.x, myQuat.y, myQuat.z, myQuat.w);
    }

    public static implicit operator Quat(Quaternion unityQuat)
    {
        return new Quat(unityQuat.x, unityQuat.y, unityQuat.z, unityQuat.w);
    }

    #endregion

    #region Properties


    public static Quat identity
    {
        get
        {
            return Quat.identity; ; //notImplemented
        }
    }

    public Vec3 eulerAngles
    {
        get
        {
            return new Vec3(); //notImplemented
        }
    }


    public Quat normalized
    {
        get
        {
            return Quat.identity;  //notImplemented
        }
    }

    #endregion

    #region Static

    public static float Angle(Quat a, Quat b)
    {
        return 0f; //notImplemented
    }

    public static Quat AngleAxis(float angle, Vec3 axis)
    {
        return Quat.identity; //ni
    }

    public static float Dot(Quat a, Quat b)
    {
        return 0f; //ni
    }

    public static Quat Euler(Vec3 euler)
    {
        return Quat.identity;  //NI
    }

    public static Quat EulerAngles(Vec3 euler)
    {
        return Quat.identity; //ni
    }

    public static Quat EulerRotation(Vec3 euler)
    {
        return Quat.identity; //ni
    }

    public static Quat FromToRotation(Vec3 fromDirection, Vec3 toDirection)
    {
        return Quat.identity; //NI
    }

    public static Quat Inverse(Quat rotation)
    {

        return Quat.identity; //NI

    }

    public static Quat Lerp(Quat a, Quat b, float t)
    {
        return Quat.identity; //NI

    }

    public static Quat LerpUnclamped(Quat a, Quat b, float t)
    {
        return Quat.identity; //NI

    }

    public static Quat LookRotation(Vec3 forward)
    {
        return Quat.identity; //NI

    }

    public static Quat LookRotation(Vec3 forward, [DefaultValue("Vec3.up")] Vec3 upwards)
    {
        return Quat.identity; //NI

    }

    public static Quat Normalize(Quat q)
    {
        return Quat.identity; //NI

    }

    public static Quat RotateTowards(Quat from, Quat to, float maxDegreesDelta)
    {
        return Quat.identity; //NI

    }

    public static Quat Slerp(Quat a, Quat b, float t)
    {
        return Quat.identity; //NI

    }

    public static Quat SlerpUnclamped(Quat a, Quat b, float t)
    {
        return Quat.identity; //NI
    }

    public static Vec3 ToEulerAngles(Quat rotation)
    {
        return Vec3.Zero;//ni
    }


    #endregion

    #region Methods

    public void Normalize()
    {
        //ni
    }

    public void Set(float newX, float newY, float newZ, float newW)
    {
        x = newX;
        y = newY;
        z = newZ;
        w = newW;
    }

    public void SetAxisAngle(Vec3 axis, float angle)
    {
        //ni
    }

    public void SetEulerAngles(Vec3 euler)
    {
        //ni
    }

    public void SetEulerRotation(Vec3 euler)
    {
        //ni
    }

    public void SetFromToRotation(Vec3 fromDirection, Vec3 toDirection)
    {
        //ni
    }

    public void SetLookRotation(Vec3 view)
    {
        SetLookRotation(view, Vec3.Up);
    }

    public void SetLookRotation(Vec3 view, Vec3 up)
    {
        //ni
    }

    public void ToAngleAxis(out float angle, out Vec3 axis)
    {
        angle = 0f;
        axis = Vec3.Zero; //ni
    }

    public Vec3 ToEuler()
    {
        return Vec3.Zero; //ni
    }


    #endregion

}
