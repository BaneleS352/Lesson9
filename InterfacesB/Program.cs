using InterfacesB.Workers;
using InterfacesB.Interfaces;

var worker = new MultiWorker();

// TODO:
// 1) Create an IWorkerA reference and call DoWork()
IWorkerA a = worker;
a.DoWork();
// 2) Create an IWorkerB reference and call DoWork()
IWorkerB b = worker;
b.DoWork();
// 3) Notice: worker.DoWork() should NOT compile if you try it (because explicit)
