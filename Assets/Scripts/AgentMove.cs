using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    public Camera cam;
    private GameObject go;
    private NavMeshAgent agent;
    private float range = 5.0f;
    private Vector3 initLocal;

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        result = center;
        initLocal = center;
        for (int i = 0; i < 30; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, range, NavMesh.AllAreas))
            {
                result = hit.position;
                return true;
            }
        }
        return true;
    }

    Vector3 PickQuad(Vector3[] positionArray)
    {
        Vector3 startPoint;

        int myIndex = Random.Range(0, 4);
        startPoint = positionArray[myIndex];

        return startPoint;
    }

    void Start()
    {
        //define in game objects
        go = GameObject.Find("character");
        agent = go.GetComponent<NavMeshAgent>();
        Vector3 point;
        //Possible starting quadrants
        Vector3[] positionArray = new Vector3[4];
        positionArray[0] = new Vector3(-15.0f, 0.0f, -30.0f);
        positionArray[1] = new Vector3(24.0f, 0.0f, -60.0f);
        positionArray[2] = new Vector3(24.0f, 0.0f, 0.0f);
        positionArray[3] = new Vector3(-93.0f, 0.0f, -30.0f);

        //Choose the agent's start and end quadrants
        agent.enabled = false;
        Vector3 startPoint = PickQuad(positionArray);
        Vector3 endPoint = PickQuad(positionArray);

        while(Vector3.Distance(startPoint, endPoint) < 10.0){
            endPoint = PickQuad(positionArray);
        }

        //Set the specific start and end locations
        if (RandomPoint(startPoint, range, out point))
        {
            go.transform.position = point;
            agent.enabled = true;
        }

        if (RandomPoint(endPoint, range, out point))
        {
            agent.SetDestination(point);
        }
    }



    // This is to click on a location and have the shooter move there
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
            else
            {
                print("Nothing hit");
            }

        }
    }
}

