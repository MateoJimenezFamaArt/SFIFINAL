using UnityEngine;
using System.IO.Ports;
using TMPro;
using System;

enum TaskState
{
    INIT,
    CHECK_INPUTS,
    
}

public class Serial : MonoBehaviour
{
    private static TaskState taskState = TaskState.INIT;
    private SerialPort _serialPort;
    private byte[] buffer;
    public TextMeshProUGUI VariableA;
    public TextMeshProUGUI VariableB;
    public TextMeshProUGUI VariableC;
    public TextMeshProUGUI VariableToggleA;
    public TextMeshProUGUI VariableToggleB;
    public TextMeshProUGUI VariableToggleC;
    public TextMeshProUGUI VariableShow;
    public TextMeshProUGUI VariableTime;
    public TextMeshProUGUI VarStarts;


    void Start()
    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "COM12";
        _serialPort.BaudRate = 115200;
        _serialPort.DtrEnable = true;
        _serialPort.Open();
        Debug.Log("Open Serial Port");
        buffer = new byte[256];
    }

    private void CleanBuffer()
    {
        Array.Clear(buffer, 0, buffer.Length);
    }

    void Update()
    {


        switch (taskState)
        {
            case TaskState.INIT:
                taskState = TaskState.CHECK_INPUTS;
                Debug.Log("WAIT START");
                break;
            case TaskState.CHECK_INPUTS:
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    byte[] data1 = { (byte)'1' }; // Sending ASCII code of '1'
                    _serialPort.Write(data1, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + data1);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableToggleA.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    byte[] data2 = { (byte)'2' }; // Sending ASCII code of '2'
                    _serialPort.Write(data2, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + data2);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableToggleB.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    byte[] data3 = { (byte)'3' }; // Sending ASCII code of '3'
                    _serialPort.Write(data3, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + data3);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableToggleC.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    byte[] data4 = { (byte)'4' }; // Sending ASCII code of '4'
                    _serialPort.Write(data4, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + data4);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableShow.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    byte[] data5 = { (byte)'5' }; // Sending ASCII code of '5'
                    _serialPort.Write(data5, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + data5);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    byte[] dataA = { (byte)'a' }; // Sending ASCII code of 'A'
                    _serialPort.Write(dataA, 0, 1);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableA.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    byte[] dataB = { (byte)'b' }; // Sending ASCII code of 'A'
                    _serialPort.Write(dataB, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + dataB);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableB.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.C))
                {
                    byte[] dataC = { (byte)'c' }; // Sending ASCII code of 'A'
                    _serialPort.Write(dataC, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + dataC);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableC.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    byte[] dataZ = { (byte)'z' }; // Sending ASCII code of 'A'
                    _serialPort.Write(dataZ, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + dataZ);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VariableTime.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }
                if (Input.GetKeyDown(KeyCode.J))
                {
                    byte[] dataJ = { (byte)'j' }; // Sending ASCII code of 'A'
                    _serialPort.Write(dataJ, 0, 1);
                    Debug.Log("Sent the following Code to the serial monitor " + dataJ);
                    if (_serialPort.BytesToRead > 0)
                    {
                        int numData = _serialPort.Read(buffer, 0, 256);
                        VarStarts.text = System.Text.Encoding.ASCII.GetString(buffer);
                        CleanBuffer();

                        Debug.Log("Recieved from pico " + numData);
                    }
                }

                break;
            default:
                Debug.Log("State Error");
                break;
        }
    }
}