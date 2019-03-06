import Axis from "./Axis";
import Cell from './Cell';
import Position from "./Position";
import * as THREE from 'three';
import PickedDimension from "../../RightDock/PickedDimension";
import CubeObject from "./CubeObject";

export interface BrowsingState{
    xAxisPickedDimension: PickedDimension|null;
    yAxisPickedDimension: PickedDimension|null;
    zAxisPickedDimension: PickedDimension|null;
    cameraState: string;
}