import React, { useEffect, useState } from 'react';
import { useMap } from 'react-use';
export const Load=()=>{
    const [isLoading, setIsLoading] = useState(true);
    const [data, setData] = useState(null);

    useEffect(() => {
        setTimeout(() => {
            setData('Fetched Data');
            setIsLoading(false);
        }, 2000);
    }, []);

    return (
        <div>
            <ExampleComponent />
            {isLoading ? (
                <h1>Loading...</h1>
            ) : (
                <h1>{data}</h1>
            )}
        </div>
    );
};


function ExampleComponent() {
  const [map, { set, remove, reset }] = useMap({ name: 'John', age: 30 });

  return (
    <div>
      <p>Name: {map.name}</p>
      <p>Age: {map.age}</p>
      <button onClick={() => set('city', 'Bangalore')}>Set City</button>
      <button onClick={() => remove('age')}>Remove Age</button>
      <button onClick={reset}>Reset</button>
    </div>
  );
}
