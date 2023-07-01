# AZURE SERVICE BUS TOPICS & SUBSCRIPTIONS

**Azure Service Bus** is a fully managed enterprise message broker with message queues and publish-subscribe topics. Service Bus is used to decouple applications and services from each other and provides reliable message queuing and durable publish/subscribe messaging. Some of the core messaging capabilities that are supported include Queues, Topics, Subscriptions, and Rules and Actions.


## Azure Service Queue

Let's use Queues in **Azure Service Bus** from a .NET application. We will create a **Queue**, send a message to it, the different message properties, consume messages from the it. We will consume it from an **Azure Function**. We will also set up Dependency Injection when working with Service Bus Clients and also use Managed Identity to connect securely with Service Bus Queues, which removes any need for sensitive configurations in the application.

### Lab – Creating a Hub

- create en event hub namespace
<img src="/pictures/event_hub.png" title="event hub"  width="900">


## Topics and Subscriptions

We will use **Topics** and **Subscriptions** in Azure Service Bus from a .NET application. We will create a new Topic, send messages to it, add multiple subscribers and process the messages. We will also add Filters and Actions when creating subscriptions and see how that affects message processing.