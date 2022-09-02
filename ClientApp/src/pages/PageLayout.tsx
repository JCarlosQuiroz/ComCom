// import Typography from "@material-ui/core/Typography";
import NavBar from "./NavBar";

export function PageLayout(props: any) {
        return (
            <div>
              <NavBar />
              {props.children}
            </div>
        );
}

// import React, { Component } from 'react';
// import { Container } from 'reactstrap';
// import { NavMenu } from './NavMenu';

// export class Layout extends Component {
//   static displayName = Layout.name;

//   render () {
//     return (
//       <div>
//         <NavMenu />
//         <Container>
//           {this.props.children}
//         </Container>
//       </div>
//     );
//   }
// }



// export const PageLayout: React.FC<{}> = (props) => {
//     return (
//         <>
//             <NavBar />
//             <Typography variant="h5" align="center">Welcome to the Microsoft Authentication Library For React Quickstart</Typography>
//             <br/>
//             <br/>
//             {props.children}
//         </>
//     );
// };