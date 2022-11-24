import React, { useEffect, useState } from "react";
import MapView, { Marker, PROVIDER_GOOGLE } from "react-native-maps";
import { StyleSheet } from "react-native";
import { View } from "native-base";
import { LatLng } from "react-native-maps/lib/sharedTypes";
import { getAedLocations } from "../services/aed/getAedLocations";
import { AedOutDto } from "../generated";

export const Map = () => {
  const [aedLocations, setAedLocations] = useState<AedOutDto[]>([]);
  const origin = { latitude: 50.0218938, longitude: 14.4626102 };
  const marker: LatLng = { latitude: 50.0218938, longitude: 14.4626102 };
  const destination = { latitude: 37.771707, longitude: -122.4053769 };
  const GOOGLE_MAPS_APIKEY = "ADD_API_KEY";

  useEffect(() => {
    getAedLocations().then(setAedLocations);
  }, []);

  return (
    <View height={"100%"}>
      <MapView
        provider={PROVIDER_GOOGLE} // remove if not using Google Maps
        style={{
          ...StyleSheet.absoluteFillObject,
        }}
        region={{
          latitude: origin.latitude,
          longitude: origin.longitude,
          latitudeDelta: 0.015,
          longitudeDelta: 0.0121,
        }}>
        {/*<MapViewDirections*/}
        {/*  origin={origin}*/}
        {/*  destination={destination}*/}
        {/*  apikey={GOOGLE_MAPS_APIKEY}*/}
        {/*  strokeWidth={3}*/}
        {/*  strokeColor="hotpink"*/}
        {/*/>*/}
        {aedLocations.map(aedLoc => (
          <Marker
            key={aedLoc.id}
            coordinate={{ latitude: aedLoc.latitude, longitude: aedLoc.longitude }}
            title={aedLoc.name}
            description={aedLoc.htmlDescription}
          />
        ))}
      </MapView>
    </View>
  );
};
