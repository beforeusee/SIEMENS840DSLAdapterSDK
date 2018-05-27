using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTConnect;

namespace SIEMENS840DSLAdapterSDK
{
    public class SiemensAdapter
    {
        //西门子适配器
        private Adapter sAdapter;

        //端口号
        private int sPort = 7812;

        //数据项
        private Event sAvail;

        //急停
        private Event sEStop;

        //控制器模式
        private Event sControllerMode;

        //系统状态
        private Condition sSystemStatus;

        //系统消息
        private Event sSystemMessage;

        //程序执行状态
        private Event sExecution;

        //程序名
        private Event sProgram;

        //主轴转速
        private Sample sSpindleRotaryVelocity;

        //主轴负载
        private Sample sSpindleLoad;

        //进给速度
        private Sample sPathFeedrate;

        //进给轴
        //X轴信息,位置,速度,负载
        private Sample sXPos;
        private Sample sXAxisFeedrate;
        private Sample sXLoad;

        //Y轴信息,位置,速度,负载
        private Sample sYPos;
        private Sample sYAxisFeedrate;
        private Sample sYLoad;

        //Z轴信息,位置,速度,负载
        private Sample sZPos;
        private Sample sZAxisFeedrate;
        private Sample sZLoad;

        //A
        private Sample sAAngle;
        private Sample sAAngularVelocity;
        private Sample sALoad;

        //B
        private Sample sBAngle;
        private Sample sBAngularVelocity;
        private Sample sBLoad;

        //C
        private Sample sCAngle;
        private Sample sCAngularVelocity;
        private Sample sCLoad;

        public SiemensAdapter(int port)
        {
            sAdapter = new Adapter();
            initDataItem();
            addDataItem();
            sAdapter.Port = port;
        }

        #region 适配器参数初始化
        private void initDataItem()
        {
            sAvail = new Event("siemens_avail");
            sEStop = new Event("siemens_estop");
            sControllerMode = new Event("siemens_controller_mode");
            sSystemStatus = new Condition("siemens_system_status", true);
            sSystemMessage = new Event("siemens_system_message");
            sExecution = new Event("siemens_execution");
            sProgram = new Event("siemens_nc_program");

            sSpindleRotaryVelocity = new Sample("siemens_spindle_rotary_velocity");
            sSpindleLoad = new Sample("siemens_spindle_load");
            sPathFeedrate = new Sample("siemens_path_feedrate");

            sXPos = new Sample("siemens_xpos");
            sXLoad = new Sample("siemens_xload");
            sXAxisFeedrate = new Sample("siemens_xvelocity");

            sYPos = new Sample("siemens_ypos");
            sYLoad = new Sample("siemens_yload");
            sYAxisFeedrate = new Sample("siemens_yvelocity");

            sZPos = new Sample("siemens_zpos");
            sZLoad = new Sample("siemens_zload");
            sZAxisFeedrate = new Sample("siemens_zvelocity");

            sAAngle = new Sample("siemens_aangle");
            sAAngularVelocity = new Sample("siemens_aangular_velocity");
            sALoad = new Sample("siemens_aload");

            sBAngle = new Sample("siemens_bangle");
            sBAngularVelocity = new Sample("siemens_bangular_velocity");
            sBLoad = new Sample("siemens_bload");

            sCAngle = new Sample("siemens_cangle");
            sCAngularVelocity = new Sample("siemens_cangular_velocity");
            sCLoad = new Sample("siemens_cload");
        }

        private void addDataItem()
        {
            sAdapter.AddDataItem(sAvail);
            sAdapter.AddDataItem(sEStop);

            sAdapter.AddDataItem(sControllerMode);

            sAdapter.AddDataItem(sSystemStatus);
            sAdapter.AddDataItem(sSystemMessage);
            sAdapter.AddDataItem(sExecution);
            sAdapter.AddDataItem(sProgram);

            //主轴
            sAdapter.AddDataItem(sSpindleRotaryVelocity);
            sAdapter.AddDataItem(sSpindleLoad);

            sAdapter.AddDataItem(sPathFeedrate);
            
            //x
            sAdapter.AddDataItem(sXPos);
            sAdapter.AddDataItem(sXAxisFeedrate);
            sAdapter.AddDataItem(sXLoad);

            //y
            sAdapter.AddDataItem(sYPos);
            sAdapter.AddDataItem(sYAxisFeedrate);
            sAdapter.AddDataItem(sYLoad);
            
            //z
            sAdapter.AddDataItem(sZPos);
            sAdapter.AddDataItem(sZAxisFeedrate);
            sAdapter.AddDataItem(sZLoad);
            
            //A
            sAdapter.AddDataItem(sAAngle);
            sAdapter.AddDataItem(sAAngularVelocity);
            sAdapter.AddDataItem(sALoad);

            sAdapter.AddDataItem(sBAngle);
            sAdapter.AddDataItem(sBAngularVelocity);
            sAdapter.AddDataItem(sBLoad);

            sAdapter.AddDataItem(sCAngle);
            sAdapter.AddDataItem(sCAngularVelocity);
            sAdapter.AddDataItem(sCLoad);

        }
        #endregion

        public void start()
        {
            sAdapter.Start();
        }

        public void stop()
        {
            sAdapter.Stop();
        }

        public void begin()
        {
            sAdapter.Begin();
        }

        public void sendChanged(string timestamp = null)
        {
            sAdapter.SendChanged(timestamp);
        }

        public void setAvailability(string availability)
        {
            sAvail.Value = availability;
        }

        public void setEStop(string estop)
        {
            sEStop.Value = estop;
        }

        public void setControllerMode(string controllermode)
        {
            sControllerMode.Value = controllermode;
        }

        public void setSystemStatus(string systemstatus)
        {
            sSystemStatus.Value = systemstatus;
        }

        public void setSystemMessage(string systemmessage)
        {
            sSystemMessage.Value = systemmessage;
        }

        public void setExecution(string execution)
        {
            sExecution.Value = execution;
        }

        public void setProgram(string program)
        {
            sProgram.Value = program;
        }

        public void setSpindleRotaryVelocity(string spindleRotaryVelocity)
        {
            sSpindleRotaryVelocity.Value = spindleRotaryVelocity;
        }

        public void setSpindleLoad(string spindleLoad)
        {
            sSpindleLoad.Value = spindleLoad;
        }

        public void setPathFeedrate(string pathFeedrate)
        {
            sPathFeedrate.Value = pathFeedrate;
        }

        public void setXPos(string xPos)
        {
            sXPos.Value = xPos;
        }

        public void setXAxisFeedrate(string xAxisFeedrate)
        {
            sXAxisFeedrate.Value = xAxisFeedrate;
        }

        public void setXLoad(string xLoad)
        {
            sXLoad.Value = xLoad;
        }

        public void setYPos(string yPos)
        {
            sYPos.Value = yPos;
        }

        public void setYAxisFeedrate(string yAxisFeedrate)
        {
            sYAxisFeedrate.Value = yAxisFeedrate;
        }

        public void setYLoad(string yLoad)
        {
            sYLoad.Value = yLoad;
        }

        public void setZPos(string zPos)
        {
            sZPos.Value = zPos;
        }

        public void setZAxisFeedrate(string zAxisFeedrate)
        {
            sZAxisFeedrate.Value = zAxisFeedrate;
        }

        public void setZLoad(string zLoad)
        {
            sZLoad.Value = zLoad;
        }

        public void setAAngle(string aAngle)
        {
            sAAngle.Value = aAngle;
        }

        public void setAAngularVelocity(string aAngularVelocity)
        {
            sAAngularVelocity.Value = aAngularVelocity;
        }

        public void setALoad(string aLoad)
        {
            sALoad.Value = aLoad;
        }

        public void setBAngle(string bAngle)
        {
            sBAngle.Value = bAngle;
        }

        public void setBAngularVelocity(string bAngularVelocity)
        {
            sBAngularVelocity.Value = bAngularVelocity;
        }

        public void setBLoad(string bLoad)
        {
            sBLoad.Value = bLoad;
        }

        public void setCAngle(string cAngle)
        {
            sCAngle.Value = cAngle;
        }

        public void setCAngularVelocity(string cAngularVelocity)
        {
            sCAngularVelocity.Value = cAngularVelocity;
        }

        public void setCLoad(string cLoad)
        {
            sCLoad.Value = cLoad;
        }


        public void setPort(int port)
        {
            this.sPort = port;
            this.sAdapter.Port = sPort;
        }
    }
}
