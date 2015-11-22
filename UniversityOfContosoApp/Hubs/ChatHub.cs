using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Web;

// At current unable to implement this feature as it breaks the University Web App. //
// namespace UniversityofContoso.Hubs  // 

// { // 
// public class ChatHub : IHttpModule  // 
//{//
//{//
/// <summary>
/// You will need to configure this module in the Web.config file of your
/// web and register it with IIS before being able to use it. For more information
/// see the following link: http://go.microsoft.com/?linkid=8101007
/// </summary>
// public class ChatHub : Hub //
// { //

//static ConcurrentDictionary<string, string> dic = new ConcurrentDictionary<string, string>(); //

//  public void Send(string name, string message) //
//  {
//     Clients.All.broadcastMessage(name, message);
// }

// public void SendToSpecific(string name, string message, string to)
//{
//  Clients.Caller.broadcastMessage(name, message);//
//  Clients.Client(dic[to]).broadcastMessage(name, message);
//   }

//public void Notify(string name, string id)
// {
// if (dic.ContainsKey(name))
//   {
//   {
//      Clients.Caller.differentName();
//  }
//     else
//  {
//  dic.TryAdd(name, id);
//  foreach (KeyValuePair<String, String> entry in dic) //
//  {
//  Clients.Caller.online(entry.Key);
// }
//  Clients.Others.enters(name);
//   }
// }

//public override Task OnDisconnected()
// {
//var name = dic.FirstOrDefault(x => x.Value == Context.ConnectionId.ToString());
//string s;
//dic.TryRemove(name.Key, out s);
//  return Clients.All.disconnected(name.Key);
// }

// }
//  } //
//} //