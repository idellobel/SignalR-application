using Microsoft.AspNet.SignalR;
namespace SignalRMVC
{
    public class DrawDot : Hub
    {
        public void UpdateCanvas(int x, int y)
        {
            Clients.All.updateDot(x, y);
        }
        public void ClearCanvas()
        {
            Clients.All.clearCanvas();
        }
    }
}