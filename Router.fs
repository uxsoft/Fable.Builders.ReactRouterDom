module Fable.Builders.ReactRouterDom.Router

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Fable.Builders.ReactRouterDom.Builders

let BrowserRouter = BrowserRouterBuilder()
let Link = LinkBuilder()
let NavLink = NavLinkBuilder()
let Routes = RoutesBuilder()
let Route = RouteBuilder()
let Outlet = OutletBuilder()


[<ImportMember("react-router-dom")>]
let useParams<'T>() : 'T = jsNative

type NavigateFn = string -> {| replace: bool; state: obj |} -> unit
[<ImportMember("react-router-dom")>]
let useNavigate : (unit -> NavigateFn) = jsNative

[<ImportMember("react-router-dom")>]
let useLocation : (unit -> Location) = jsNative

[<ImportMember("react-router-dom")>]
let useHref : (string -> string) = jsNative