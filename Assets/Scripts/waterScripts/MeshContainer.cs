// Source: Aigei, Tropic Environment Pack [online] Available at:< https://www.aigei.com/item/unity3d_da_hai.html > [Accessed 17 Apr. 2021].

using UnityEngine;

public class MeshContainer 
{
  public Mesh mesh;
  public Vector3[] vertices;
  public Vector3[] normals;
  
  public MeshContainer(Mesh m) {
    mesh = m;
    vertices = m.vertices;
    normals = m.normals;
  }
  
  public void Update() {
    mesh.vertices = vertices;
    mesh.normals = normals;
  }
}