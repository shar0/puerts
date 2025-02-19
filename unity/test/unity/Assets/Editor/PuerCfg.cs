using Puerts;
using System;
using System.Collections.Generic;

[Configure]
public class PuerCfg {
    [Binding]
    public static List<Type> binding {
        get {
            return new List<Type>{
                typeof(UnityEngine.Vector3),
                typeof(Dictionary<int, int>),
                typeof(Dictionary<int, int>.Enumerator),
                typeof(List<int>.Enumerator),
                typeof(Puerts.UnitTest.HelperExtension),
                typeof(Puerts.UnitTest.ExtensionTestHelper),
                typeof(Puerts.UnitTest.ExtensionTestHelperDerived),
                typeof(Puerts.UnitTest.ExtensionTestHelper1),
                typeof(Puerts.UnitTest.ExtensionTestHelperDerived1)
            };
        }
    }
}