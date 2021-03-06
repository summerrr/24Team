# CanTool APP功能需求
  
  &nbsp;&nbsp;在现代汽车控制技术中，汽车中会使用多个电子控制装置（ECU：Electronic Control Unit）对整车进行控制。而ECU之间的信息交换更多地依赖于CAN(Controller Area Network)总线的网络连接方式来完成。为了检测和控制CAN bus的信息内容，需要使用CAN bus检测设备。CanTool装置是完成CANbus检测的工具。为了实现CAN数据的显示及控制，需要使用本文提出的CanToolApp软件,该软件需要将连接在CAN总线上的CanTool装置采集的CAN信息发送到上位机（移动终端Android、iOS、Windows PC）上。
通过对需求文档进行整理与讨论，我们将Cantool APP的功能主要分为以下四个模块,如下图：
![image](https://github.com/incomparableTJU/24Team/raw/master/CanToolApp%E5%8A%9F%E8%83%BD.jpg)
## 一、CanToolApp对CAN信息==显示处理==功能： 
1. 显示数据分为3种：
* 从CanTool装置接收的数据
* 用户发送的数据
* 加载的用户提供的数据
2. 显示“接收”数据的处理操作:
* 接受到的数据需要根据CAN信息及信号描述数据库对数据字符串进行解析,然后得到CAN信息中包含的各种CAN信号值。
* 将此CAN信号值进一步进行计算,还原该信号所代表的物理量的信息，并显示在GUI界面上。
3. 显示“发送”数据的处理操作:
* 发送的数据需要采用同种方式，将用户输入的物理值转换为CAN信号。
* 依据CAN信号描述数据库将属于同一个CAN ID的信号合成为字符串发送给CanTool装置。
4、显示“加载”数据的处理操作，完成CAN信号数据的解析以及CAN发送信息的组装，同“发送”过程。
## 二、CanToolAPP GUI==界面==显示：
1. COM口基本设定信息界面
2. Can基本设定信息界面
3. Can信息原始数据及物理数据实时显示界面
4. Can信号物理值的仪表盘
5. Can信号实时曲线
6. Can信号在Can信息中的布局图
7. Can信号树状结构图
## 三、CanToolAPP 的数据==存储==功能：
1. 用户选择的显示方式可保存到CanToolApp设定文件中，供下次使用。
2. 可以将接收到的所有CAN信息数据，实时保存为数据文件。格式为CSV格式，或自定义。
3. 可以加载用户提供的CAN信息和信号数据库，加载的数据库文件相关信息，可保存到CanToolApp设定文件中，供下次使用。
4. 可以将用户提供的CAN信息和信号数据库另存为xml和JSON (JavaScript Object Notation)格式。
5. 可以将xml或Json格式的数据库，转换为CAN信息和信号数据库格式。
## 四、CanToolAPP 通过==控制==CanTool装置控制Can通信功能：
1. CanToolApp可以设定CAN总线的通信参数，并通过相应的命令设置CanTool装置的CAN通信参数，以使CanTool装置能够与CAN总线上的其他被测ECU进行正常的通信。
2. 能够搜索到本机所有可使用的COM口，并在弹出式ComboBox中以列表方式让用户选择CanTool装置在上位机中映射的COM口。并设置相应COM口波特率115200、数据位数8、停止位数1。
3. 能够实现CANtool装置的CAN速率设置、进入CAN工作状态（Open）、进入CAN初始化状态（ Close）。
4. 控制显示方式,显示时可以让用户选择仪表盘方式显示接收到CAN信号物理值。
5. 允许用户设定CAN信息中的CAN信号物理值,App可将用户设定的物理值转换为CAN信号值，将CAN信息中包含的所有CAN信号合成完整的CAN信息后，发送给CanTool装置，发送到CAN总线上。