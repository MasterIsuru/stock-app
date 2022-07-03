import { render, screen } from "@testing-library/react";
import { tableMetaData } from "views/stock/label";
import StockTable from "./index";

const data = [
  {
    id: 1,
    time: "2022-2-2 08:02:00",
    price: 100,
  },
];

test("renders stock data", () => {
  render(<StockTable />);
  const linkElement = screen.getByText(/No data found/i);
  expect(linkElement).toBeInTheDocument();
});

test("renders stock data", () => {
  render(<StockTable tableMeta={tableMetaData} tableData={data} />);
  const linkElement = screen.getByText(/Price/i);
  expect(linkElement).toBeInTheDocument();
});
