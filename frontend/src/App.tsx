import React from "react";
import { SafeAreaView } from "react-native";

import { Node } from "@babel/core";
import { NativeBaseProvider } from "native-base";
import { Map } from "./components/Map";

const App: () => Node = () => {
  return (
    <NativeBaseProvider>
      <SafeAreaView>
        <Map />
      </SafeAreaView>
    </NativeBaseProvider>
  );
};

export default App;
