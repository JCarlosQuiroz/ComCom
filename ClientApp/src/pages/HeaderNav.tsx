import { IButtonStyles, IconButton, Image, IStackStyles, ITextFieldStyles, Stack, TextField } from '@fluentui/react';
import * as React from 'react';
import { Images } from '../styles/Theme';
import { AvatarUser } from './AvatarUser';

const searchBarStackStyles: IStackStyles = {
  root: {
    height: 50,
    width: "auto",
    alignItems: "center",
    margin: "0px 250px",
    placeContent: "center",
    float: "right",
    display: "inline-flex",

  }
};
const searchBarIconButtonStyles: IButtonStyles = {
  root: {
    marginRight: 6,
    padding: 0,
    color: "#FFFFFF",
    transform: "rotate(270deg)",
    fontSize: "x-large",
    outline: "transparent",
  },
  icon: {
    margin: 0
  }
};
const searchBarTextFieldStyles: ITextFieldStyles = {
  root: {
    width: 600,
  },
  fieldGroup: { border: "none" },
  prefix: {},
  suffix: {},
  field: {
    fontSize: 13.3333,
    padding: 0,
    textAlign: "center"
  },
  icon: {},
  description: {},
  wrapper: {},
  errorMessage: {},
  subComponentStyles: {
    label: {}
  },
  revealButton: {},
  revealSpan: {},
  revealIcon: {}
};
const HeaderNav: React.FunctionComponent = () => {
  return (

    <div className="ms-Grid-row docs-Header ms-fontColor-white ms-bgColor-themeDarker">
      <div className="ms-Grid-col ms-sm12 ms-md3 ms-lg2">
        {/* <img src={require("../dist/img/customSw.png")} alt="logo" style={{ width: 40, paddingTop: 5 }} /> */}
        <Image
          src={Images.reportsLogo}
          width={40}
          height={40}
          alt="Reports Logo"
          styles={{
            root: {
              paddingTop: 5,
            },
          }}
        />

        <a className='ms-Grid-col ms-sm12 ms-md3 ms-lg2 ms-font-m ms-font-weight-regular ms-fontSize-xl' href='/'>
          Portal - Serdi®
        </a>
      </div>

      <div className="ms-Grid-col ms-sm ms-md3 ms-lg6">
        <div className="ms-font-m ms-fontColor-white ms-font-weight-regular ms-fontSize-xl">
          <Stack
            horizontal
            verticalAlign="center"
            styles={searchBarStackStyles}
          >
            <TextField
              placeholder="Buscar..."
              styles={searchBarTextFieldStyles}
            />
            <IconButton
              iconProps={{ iconName: "Search" }}
              styles={searchBarIconButtonStyles}
            />
          </Stack>
        </div>
      </div>
      <div className="ms-Grid-col ms-sm12 ms-md3 ms-lg2">
        <AvatarUser />
      </div>
    </div>

  );
};

export default HeaderNav;


