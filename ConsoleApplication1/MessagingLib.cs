using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsoleApplication1
{
	public class RabbitMqService
	{
		private string _hostName = "localhost";
		private string _userName = "admin";
		private string _password = "admin";
		private string _queue = "CalculatorQueue";
		private string _exchangeName = "";
		private bool _durable = true;

		public void InitialQueue(IModel model)
		{
			model.QueueDeclare(_queue, _durable, false);
		}
		public IConnection GetRabbitMqConnection()
		{
			ConnectionFactory connectionFactory = new ConnectionFactory();
			connectionFactory.HostName = _hostName;
			connectionFactory.UserName = _userName;
			connectionFactory.Password = _password;

			return connectionFactory.CreateConnection();
		}
		public void SendOneWayMessage(string message, IModel model)
		{
			IBasicProperties basicProperties = model.CreateBasicProperties();
			basicProperties.Persistent = _durable;
			byte[] messageBytes = Encoding.UTF8.GetBytes(message);
			model.BasicPublish(_exchangeName, _queue, basicProperties, messageBytes);
		}

		public void ReceiveOneWayMessage(IModel model)
		{
			model.BasicQos(0, 1, false);
			QueueingBasicConsumer consumer = new QueueingBasicConsumer(model);
			model.BasicConsume(_queue, false, consumer);
			while (true)
			{
				BasicDeliverEventArgs deliveryArguments = consumer.Queue.Dequeue();
				String message = Encoding.UTF8.GetString(deliveryArguments.Body);
				Console.WriteLine("Message received: {0}", message); //TODO 
				model.BasicAck(deliveryArguments.DeliveryTag, false);
			}
		}
	}
}
