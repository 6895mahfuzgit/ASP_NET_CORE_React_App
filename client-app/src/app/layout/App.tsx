import React, { useState,useEffect } from 'react';
import axios from 'axios';
import { Header, Icon, List } from 'semantic-ui-react'
import { IActivity } from '../models/activity';


const App=()=>{
 const[activities,setActivities]=useState<IActivity[]>([]);

 useEffect(()=>{
   axios.get<IActivity[]>('http://localhost:5000/api/activities').then((response) => {
   setActivities(response.data)
   })
 },[]);
  // componentDidMount() {
  
  //   });
  // }
    return (
      <div>
        <Header as='h2'>
          <Icon name='users' />
          <Header.Content>React ASP.NET Core</Header.Content>
        </Header>

        <List>
          {activities.map((activitie) => (
              <List.Item key={activitie.id}>{activitie.title}</List.Item>
            ))
          }
        </List>
      </div>
    );
}

export default App;
