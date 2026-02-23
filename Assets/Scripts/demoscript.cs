using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class demoscript : MonoBehaviour
{
    [SerializeField]
    private int myNumOne;
    [SerializeField]
    private int myNumTwo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(myNumOne = findSum(myNumOne, myNumTwo));
        print(myNumOne = findDiff(myNumOne, myNumTwo));
        print(myNumOne = findProduct(myNumOne, myNumTwo));
        print(myNumOne = findQuotient(myNumOne, myNumTwo));
    }

    private int findSum(int addendOne, int addendTwo)
    {
        int sum = addendOne + addendTwo;
        return sum;
    }

    private int findDiff(int subbendOne, int subbendTwo)
    {
        int difference = subbendOne - subbendTwo;
        return difference;
    }

    private int findProduct(int multOne, int multTwo)
    {
        int product = multOne * multTwo;
        return product;
    }

    private int findQuotient(int divOne, int divTwo)
    {
        int quotient = divOne / divTwo;
        return quotient;
    }
}
