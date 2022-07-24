module Fable.Builders.ReactRouterDom

open Browser.Types
open Fable.Builders.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type BrowserRouterBuilder() =
    inherit ReactBuilder(import "BrowserRouter" "react-router-dom")
    [<CustomOperation("basename")>] member inline _.basename(x: DSLElement, v: string) = x.attr "basename" v
let BrowserRouter = BrowserRouterBuilder()

type LinkBuilder() =
    inherit ReactBuilder(import "Link" "react-router-dom")
    [<CustomOperation("replace")>] member inline _.replace(x: DSLElement, v: bool) = x.attr "replace" v
    [<CustomOperation("state")>] member inline _.state(x: DSLElement, v: 'v) = x.attr "state" v
    [<CustomOperation("href")>] member inline _.href(x: DSLElement, v: string) = x.attr "to" v
    [<CustomOperation("reloadDocument")>] member inline _.reloadDocument(x: DSLElement, v: bool) = x.attr "reloadDocument" v
let Link = LinkBuilder()

type NavLinkBuilder() =
    inherit ReactBuilder(import "NavLink" "react-router-dom")
    [<CustomOperation("replace")>] member inline _.replace(x: DSLElement, v: bool) = x.attr "replace" v
    [<CustomOperation("state")>] member inline _.state(x: DSLElement, v: 'v) = x.attr "state" v
    [<CustomOperation("href")>] member inline _.href(x: DSLElement, v: string) = x.attr "to" v
    [<CustomOperation("reloadDocument")>] member inline _.reloadDocument(x: DSLElement, v: bool) = x.attr "reloadDocument" v
let NavLink = NavLinkBuilder()

type RoutesBuilder() =
    inherit ReactBuilder(import "Routes" "react-router-dom")
let Routes = RoutesBuilder()


type RouteBuilder() =
    inherit ReactBuilder(import "Route" "react-router-dom")
    [<CustomOperation("caseSensitive")>] member inline _.caseSensitive(x: DSLElement, v: bool) = x.attr "caseSensitive" v
    [<CustomOperation("element")>] member inline _.element(x: DSLElement, v: ReactElement) = x.attr "element" v
    [<CustomOperation("index")>] member inline _.index(x: DSLElement, v: bool) = x.attr "index" v
    [<CustomOperation("path")>] member inline _.path(x: DSLElement, v: string) = x.attr "path" v
let Route = RouteBuilder()

type OutletBuilder() =
    inherit ReactBuilder(import "Outlet" "react-router-dom")
let Outlet = OutletBuilder()

[<ImportMember("react-router-dom")>]
let useParams<'T>() : 'T = jsNative

[<ImportMember("react-router-dom")>]
let useNavigate : (unit -> (string -> {| replace: bool; state: obj |} -> unit)) = jsNative

[<ImportMember("react-router-dom")>]
let useLocation : (unit -> Location) = jsNative

[<ImportMember("react-router-dom")>]
let useHref : (string -> string) = jsNative