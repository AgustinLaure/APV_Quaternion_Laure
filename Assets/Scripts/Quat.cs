using UnityEngine;
//hacer iquatable & ienumarator
public struct Quat
{
    private float x;
    private float y;
    private float z;
    private float w;

    public Quat(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }



    //public static Quat Identity { get { return new Quat(0f, 0f, 0f, 0f); } }
    //public Vec3 EulerAngles
    //{
    //    get
    //    {
    //        return;
    //    }
    //}
    //
    //public Quat Normalized
    //{
    //    get
    //    {
    //        return;
    //    }
    //}
}
