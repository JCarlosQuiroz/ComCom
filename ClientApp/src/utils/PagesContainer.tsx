import React from 'react';
import { Link } from "react-router-dom";
import { PageLayout } from '../pages/PageLayout';






export const PageContainer: React.FunctionComponent = () => {
  return (
    <PageLayout>
    <ul>
    <li>
      <Link to="/">Home</Link>
    </li>
    <li>
      <Link to="/about">About</Link>
    </li>
    <li>
      <Link to="/dashboard">Dashboard</Link>
    </li>
    <li>
      <Link to="/profile">Profile</Link>
    </li>
    
  </ul>
  </PageLayout>
  );
}

export default PageContainer;