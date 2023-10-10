import EventEmiiter from 'event';
class ChatRoom extends EventEmiiter{
    sendMessage(user,message)
{
    console.log(`${user}:${message}`);
    this.emit('newMessage',{user,message});

}
}
const ChatRoom=new ChatRoom();
ChatRoom.on('newMessage',({user,message}) => {
console.log(`recevied message from ${user} ${message})`)});
ChatRoom.sendMessage('userA','Hello everyone!');