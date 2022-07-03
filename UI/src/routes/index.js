import { Suspense, lazy } from "react";

import { PageLoader } from "components";
import { BrowserRouter, Routes, Route } from "react-router-dom";

import { RoutePaths } from "./routePaths";

const Stock = lazy(() => import("../views/stock"));
const NotFound = lazy(() => import("../views/notFound"));

const Router = () => {
  return (
    <BrowserRouter>
      <Suspense fallback={<PageLoader />}>
        <Routes>
          <Route path={RoutePaths.root} element={<Stock />} />
          <Route path={RoutePaths.notFound} element={<NotFound />} />
        </Routes>
      </Suspense>
    </BrowserRouter>
  );
};

export default Router;
