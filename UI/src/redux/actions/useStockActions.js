import { useDispatch } from "react-redux";
import {
  setTickerData,
  setStockTableData,
  setPriceSourceData,
} from "../reducers/stockSlice";

const useStockActions = () => {
  const dispatch = useDispatch();

  const setTickerDataDispatch = (data) => {
    dispatch(setTickerData(data));
  };
  const setStockTableDataDispatch = (data) => {
    dispatch(setStockTableData(data));
  };
  const setPriceSourceDataDispatch = (data) => {
    dispatch(setPriceSourceData(data));
  };

  return {
    setTickerDataDispatch,
    setStockTableDataDispatch,
    setPriceSourceDataDispatch,
  };
};

export default useStockActions;
