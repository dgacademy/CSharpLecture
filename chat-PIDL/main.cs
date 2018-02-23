// C2S RMI function definitions.
global Simple 2000
{
	// Example that send chatting message to server
	RequestChat([in] String message);
	ReplyChat([in] String message);
}