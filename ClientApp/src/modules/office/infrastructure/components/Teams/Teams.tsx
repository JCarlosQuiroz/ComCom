import { ContextualMenu,Text, IButtonStyles, IconButton, IDragOptions, IIconProps, IStackStyles, IStackTokens, ITextField, ITextFieldStyles, ITextStyles, PersonaCoin, PersonaInitialsColor, PersonaSize, Separator, Stack, TextField, IPersonaCoinStyles } from "@fluentui/react";
import { useBoolean, useId } from "@fluentui/react-hooks";
import React from "react";
import { ISepStyles, Theme } from "../../../../../styles/Theme";

export interface IChatBoxProps {
    alignment: "start" | "end";
    text: string;
  }
  
  export const ChatBox = (props: IChatBoxProps) => {
    const { alignment, text } = props;
  
    const personaCoinStyles: IPersonaCoinStyles = {
      coin: {
        marginRight: alignment === "start" ? 10 : 0,
        marginTop: 5
      },
      imageArea: {},
      image: {},
      initials: {},
      size10WithoutPresenceIcon: {}
    };
    const chatBubbleStackStyles: IStackStyles = {
      root: {
        backgroundColor: alignment === "start" ? "#2D2C2C" : "#3A3B55",
        borderRadius: 5,
        marginRight: alignment === "end" ? 10 : 0,
        padding: "5px 10px"
      }
    };
    const userNameTextStyles: ITextStyles = {
      root: {
        color: "#ABA8A6"
      }
    };
    const chatTextStyles: ITextStyles = {
      root: {
        color: "#EEEEEE"
      }
    };
  
    return (
      <Stack.Item align={alignment}>
        <Stack horizontal>
          {alignment === "start" && (
            <PersonaCoin
              size={PersonaSize.size32}
            //   imageUrl={TestImages.personaFemale}
             initialsColor={PersonaInitialsColor.blue}
              styles={personaCoinStyles}
            />
          )}
          <Stack maxWidth={300} styles={chatBubbleStackStyles}>
            <Text variant="small" styles={userNameTextStyles}>
              {alignment === "start" ? "Annie Lindqvist" : "Ted Randall"}
            </Text>
            <Text variant="smallPlus" styles={chatTextStyles}>
              {text}
            </Text>
          </Stack>
          {alignment === "end" && (
            <PersonaCoin
              size={PersonaSize.size32}
            //   imageUrl={TestImages.personaMale}
            initialsColor={PersonaInitialsColor.blue}
              styles={personaCoinStyles}
            />
          )}
        </Stack>
      </Stack.Item>
    );
  };
  
  export interface IChatInterfaceState {
    chatBoxes: JSX.Element[];
    message: string | undefined | null | ITextField | ITextFieldStyles | any; 
  }

  export class ChatInterface extends React.Component<{}, IChatInterfaceState> {
    constructor(props: {}) {
      super(props);
      this.state = {
        chatBoxes: [],
        message: ""
      };
    }
  
    public render() {
      const { chatBoxes, message } = this.state;
  
      const outerStackStyles: IStackStyles = {
        root: {
          height: "550px",
          width: "100%"
        }
      };
      const chatStackStyles: IStackStyles = {
        root: {
          backgroundColor: "#201F1F",
          height: "100%",
          overflow: "auto",
          padding: 15,
          width: "80%"
        }
      };
      const messageStackStyles: IStackStyles = {
        root: {
          backgroundColor: "#201F1F",
          padding: "10px 15px",
          width: "80%"
        }
      };
      const messageTextFieldStyles: ITextFieldStyles = {
          root: {
              width: "100%"
          },
          fieldGroup: {
              backgroundColor: "#2D2C2C",
              border: "none",
              borderRadius: 3
          },
          prefix: {},
          suffix: {},
          field: {
              borderBottom: "2px solid transparent",
              color: "#EEEEEE",
              paddingBottom: 12,
              paddingTop: 12,

              selectors: {
                  ":focus": {
                      borderBottom: "2px solid #A7A8D8"
                  },
                  "::placeholder": {
                      color: "#ABA8A6"
                  }
              }
          },
          icon: {},
          description: {},
          wrapper: {},
          errorMessage: {},
          subComponentStyles: {
              label: {}
          },
          revealButton: undefined,
          revealSpan: undefined,
          revealIcon: undefined
      };
      const iconButtonStyles: IButtonStyles = {
        root: {
          width: 20
        },
        icon: {
          color: "#ABA8A6",
          fontSize: 18
        },
        iconHovered: {
          color: "#A7A8D8"
        }
      };
  
      const chatStackTokens: IStackTokens = { childrenGap: 8 };
      const messageStackTokens: IStackTokens = { childrenGap: 8 };
  
      return (
        <Stack horizontalAlign="center" styles={outerStackStyles}>
          <Stack styles={chatStackStyles} tokens={chatStackTokens}>
            <ChatBox
              alignment="start"
              text="Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            />
            <ChatBox
              alignment="end"
              text="Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            />
            <ChatBox
              alignment="end"
              text="Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
            />
            <ChatBox
              alignment="start"
              text="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
            />
            <ChatBox
              alignment="start"
              text="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            />
            {chatBoxes}
          </Stack>
          <Stack
            horizontal
            styles={messageStackStyles}
            tokens={messageStackTokens}
          >
            <TextField
              placeholder="Type a new message"
              styles={messageTextFieldStyles}
              onChange={this._onMessageChange}
              onKeyDown={this._onKeyDown}
              value={message}
            />
            <IconButton
              iconProps={{ iconName: "Send" }}
              styles={iconButtonStyles}
              onClick={this._onSendNewMessage}
            />
          </Stack>
        </Stack>
      );
    }
  
    private _onKeyDown = (
      ev: React.KeyboardEvent<HTMLInputElement | HTMLTextAreaElement>
    ) => {
      if (ev.keyCode === 13) {
        this._onSendNewMessage();
      }
    };
  
    private _onMessageChange = (
      ev: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>,
      value?: string
    ) => {
      this.setState({ message: value });
    };
  
    private _onSendNewMessage = () => {
      const { chatBoxes, message } = this.state;
      if (message !== "") {
        chatBoxes.push(<ChatBox alignment="end" text={message} />);
        this.setState({ chatBoxes, message: "" });
      }
    };
  }

// export function MicrosoftTeams() {
//     <Stack horizontalAlign='center' tokens={{ padding: '10px 0px 0px 0px', childrenGap: '3%', maxHeight: '100%', maxWidth: '100%' }}>
//     <Separator theme={Theme} styles={ISepStyles}>Teams</Separator>
//     <Stack horizontalAlign='center' horizontal wrap tokens={{ padding: '0px 0px 0px 0px', childrenGap: 20 }}>
//         <h1>Teams</h1>
//         <a>aqui va el componente</a>
//     </Stack>
// </Stack>
// }


// export function ChatInterface (){
//     const [isModalOpen, {setTrue:showModal, setFalse: hideModal}] = useBoolean(false);
//     const [isDraggable, { toggle: toggleIsDraggable }] = useBoolean(false);
//     const [keepInBounds] = useBoolean(true);
//     const dragOptions = React.useMemo(
//         (): IDragOptions => ({
//             moveMenuItemText: 'Move',
//             closeMenuItemText: 'Close',
//             menu: ContextualMenu,
//             keepInBounds,
//             dragHandleSelector: '.ms-Dialog-draggableHeader',
//         }),
//         [keepInBounds],
//     );
//     const titleId = useId('title');
//     const subtitleId = useId('subText');
//     const cancelIcon: IIconProps = { iconName: 'Cancel' };
//     const openIcon: IIconProps = { iconName: 'OpenFile' };

//     return(
//         <div>
//             <h1>Chat</h1>
//             <a>chat</a>
//         </div>
//     )
// }