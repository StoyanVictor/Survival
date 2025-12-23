using UnityEngine;
namespace Project.CodeBase.Infrastructure.Services {
    public class Factory {

        public GameObject CreateSomething(GameObject prefab, Transform pos) {

            return Object.Instantiate(prefab,pos.transform.position,Quaternion.identity,null);
        }
    }
}