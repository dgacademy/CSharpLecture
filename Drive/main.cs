using UnityEngine;
using System.Collections;
using Nettention.Proud;

 public class Drive1 : MonoBehaviour {

	public float speed = 2.0f;
	public float rotationSpeed = 180.0f;
	UnityEngine.Vector3 startPos;

    NetClient c;
    public static string Version = "3ae33249-ecc6-4980-bc5d-7b0a999c0739";
    public static int serverPort = 33334;


    Simple.Proxy proxy = new Simple.Proxy();
    Simple.Stub stub = new Simple.Stub();

    void Start()
	{
		startPos = this.transform.position;

        c = new NetClient();
        NetConnectionParam cp = new NetConnectionParam();
        //Guid.ConvertStringToUUID(Version, cp.protocolVersion);
        cp.protocolVersion.Set(new System.Guid(Version));
        cp.serverIP = "localhost";
        cp.serverPort = (ushort)serverPort;

        c.JoinServerCompleteHandler = (info, replyFromServer) =>
        {
            if (info.errorType == ErrorType.ErrorType_Ok)
            {
                print("Succeed to connect server. Allocated hostID=" + c.GetLocalHostID());
                GameObject.Find("JEEP_BODY").GetComponent<MeshRenderer>().material.color = Color.magenta;
            }
            else
            {
                // connection failure.
                print("Failed to connect server.\n");
                print("errorType = " + info.errorType);
            }
        };
        c.LeaveServerHandler = (errorInfo) =>
        {
                // show why disconnected.
                print("OnLeaveServer: " + errorInfo.comment);
        };

        stub.Move = (remote, ctx, x, y, z) =>
        {
            print("x: " + x);
            return true;
        };

        c.AttachProxy(proxy);
        c.AttachStub(stub);
        c.Connect(cp);
    }


	void Update() {

		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

		if(Input.GetButtonDown("Jump"))
		{
			this.transform.position = startPos;
            var data = System.Text.Encoding.UTF8.GetBytes("payload");
            c.SendUserMessage(HostID.HostID_Server, RmiContext.ReliableSend, new ByteArray(data));
            
        }
        c.FrameMove();
    }

    private void OnDestroy()
    {
        c.Disconnect();
    }
    //public override void OnStartLocalPlayer()
    //{
    //	GameObject.Find ("JEEP_BODY").GetComponent<MeshRenderer> ().material.color = Color.magenta;
    //}
}
