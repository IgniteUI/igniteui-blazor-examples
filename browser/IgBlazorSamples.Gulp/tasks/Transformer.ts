/* eslint-disable @typescript-eslint/no-var-requires */

let transFS = require('fs.extra');

// let platform = "React";
// let igConfig = require('./gulp-config.js')[platform];

let igConfig = require('./gulp-config.js')

// function log(msg) {
//     console.log('Transformer.ts ' + msg);
// }
// log('loaded');
class SampleFile {
    public Content: string;
    public Name: string;
    public Path: string;
    public Parent: string;
    public IsChanged: boolean;

    constructor() {
        this.Content = "";
        this.Path = "";
        this.Name = "";
        this.IsChanged = false;
    }

    public isRazorFile(): boolean {
        // return this.Path.indexOf("Pages") > 0 && this.Name.endsWith(".razor");
        return this.Name.endsWith(".razor");
    }
    public isRazorComponent(): boolean {
        return this.Path.indexOf("Components") > 0 && this.Name.endsWith(".razor");
    }
    public isCS(): boolean {
        return this.Name.endsWith(".cs") && !this.Name.endsWith(".css");
    }
    public isProgramCS(): boolean {
        return this.Name.endsWith("Program.cs");
    }
    public isHTML(): boolean {
        return this.Name.endsWith(".html");
    }
    public isPublicJS(): boolean {
        return this.Path.indexOf("wwwroot") > 0 && this.Name.endsWith(".js");
    }
    public isPublicCSS(): boolean {
        return this.Path.indexOf("wwwroot") > 0 && this.Name.endsWith(".css");
    }
}


class SampleSourceFile extends SampleFile {
    // public LocalPath: string;
    // public Blocks: SampleSourceBlock;
    // public Content: string;
    // public Name: string;
    // public Path: string;
    // public IsChanged: boolean;

    constructor(file: SampleFile, modules: string[]) {
        super();
        this.Content = file.Content;
        this.Path = file.Path;
        this.Name = file.Name;
        this.IsChanged = file.IsChanged;

        // remove lines with old Register(IgniteUIBlazor)
        var oldLines = this.Content.split("\r\n");
        var newLines: string [] = [];
        for (const line of oldLines) {
            if (line.indexOf(".Register(IgniteUIBlazor)") < 0){
                newLines.push(line);
            }
        }
        this.Content = newLines.join("\r\n");

        // add OnInitialized() if it is missing
        if (this.Content.indexOf("OnInitialized()") < 0) {
            var codeReplace = "@code {\r\n";
            var codePaste   = "    protected override void OnInitialized()\r\n    {\r\n    }\r\n";
            this.Content = this.Content.replace(codeReplace, codeReplace + codePaste);
        }

        // add lines with new Register(IgniteUIBlazor)
        if (modules !== undefined && modules.length > 0) {
            // console.log("update " + this.Path + " modules: " + (modules.join(','));

            // adding IG injection if it is missing
            var codeUsingIG  = "@using IgniteUI.Blazor.Controls";
            var codeInjectIG = "@inject IIgniteUIBlazor IgniteUIBlazor";
            if (this.Content.indexOf(codeInjectIG) < 0 &&
                this.Content.indexOf(codeUsingIG) >= 0) {
                this.Content = this.Content.replace(codeUsingIG, codeUsingIG + "\n" + codeInjectIG);
            }

            // inserting IG modules from Program.CS to App.razor file
            var moduleReplace = "OnInitialized()\r\n    {";
            var moduleInsert = "\r\n";
            for (const module of modules) {
                moduleInsert += "        " + module + ".Register(IgniteUIBlazor);\r\n"
            }
            this.Content = this.Content.replace(moduleReplace, moduleReplace + moduleInsert);
        }
    }
}

// this class provides information about a sample that is implemented in /samples folder
class SampleInfo {
    public ComponentGroup: string;     // maps
    public ComponentFolder: string;    // geo-map
    public ComponentName: string;      // Geo Map

    // public SampleDirOnDisk: string;    // C:\repo\igniteui-react-examples\samples\maps\geo-map\binding-csv-points\
    public SampleFolderPath: string;     // /samples/maps/geo-map/binding-csv-points/
    public SampleFilePath: string;       // /samples/maps/geo-map/binding-csv-points/src/MapBindingDataCSV.razor
    public SampleRouteNew: string;       //         /maps/geo-map/binding-csv-points/
    public SampleRouteOld: string;       //         /maps/geo-map-binding-csv-points/
    public SampleFolderName: string;     //                       binding-csv-points
    public SampleFileName: string;       // MapBindingDataCSV.razor
    // public SampleImportName: string;     // MapBindingDataCSV
    // public SampleImportPath: string;     // ./geo-map/binding-csv-points/MapBindingDataCSV
    public SampleDisplayName: string;  // Map Binding Data CSV
    // public SampleFileSourcePath: string;     // /src/MapBindingDataCSV.razor
    // public SampleFileSourceCode: string;   // source code from /src/MapBindingDataCSV.razor file
    // public SampleFileSourceBlock: SampleSourceBlock;
    // public SampleImportPackages: string[];
    // public SampleImportFiles: string[];

    public IsComplete: boolean;
    public SampleReadMe: string;       // content of ReadMe.md file generated for /samples/maps/geo-map/binding-csv-points/
    // public SampleFilePaths: string[];  // relative paths to files in sample folder: /samples/maps/geo-map/binding-csv-points/
    // public SampleFileNames: string[];  // names of files in sample folder: /samples/maps/geo-map/binding-csv-points/
    public SourceFiles: SampleFile[];
    public SourceRazorFile: SampleSourceFile;
    public PublicFiles_JS: SampleFile[];
    public PublicFiles_CSS: SampleFile[];
    public PublicIndexFile: SampleFile;
    public ProjectFile: SampleFile;
    public ProgramModules: string[];
    public DataFilesCount: number = 0;

    public DocsUrl: string;            // https://infragistics.com/Reactsite/components/geo-map.html

    public SandboxUrlView: string;     // https://codesandbox.io/embed/github/IgniteUI/igniteui-react-examples/tree/master/samples/maps/geo-map/binding-csv-points
    public SandboxUrlEdit: string;     //     https://codesandbox.io/s/github/IgniteUI/igniteui-react-examples/tree/master/samples/maps/geo-map/binding-csv-points
    public SandboxUrlShort: string;    //     https://codesandbox.io/s/github/IgniteUI/igniteui-react-examples/tree/master/samples/maps/geo-map/binding-csv-points

    public PackageFileContent: PackageJson;
    public PackageDependencies: PackageDependency[];

    constructor() {
        // this.SampleFileSourceCode = '';
        // this.SampleFilePaths = [];
        // this.SampleFileNames = [];
        this.SourceFiles = [];
        this.PublicFiles_JS = [];
        this.PublicFiles_CSS = [];
        this.PackageDependencies = [];
        // this.PackageDependencies.indexOf
    }

    public isUsingFileName(name: string): boolean {
        for (const file of this.SourceFiles) {
            if (file.Name.indexOf(name)) {
                return true;
            }
        }
        return false; // this.SampleFileNames.includes(name);
    }

    // public print() {
    //     var str = "";
    // }
}

class SampleGroup {
    public Name: string;
    public Components: SampleComponent[];
    public IsDeprecated: boolean;

    constructor() {
        this.Components = [];
    }
}

class SampleComponent {
    public Name: string;
    public Group: string;
    public Samples: SampleInfo[];
    public IsDeprecated: boolean;

    constructor() {
        this.IsDeprecated = false;
        this.Samples = [];
    }
}

class Transformer {

    // splits source code of a sample into block lines with imports, packages, and other lines
    // public static getSampleBlocks(sampleSourceCode: string): SampleSourceBlock {
    //     let sourceBlocks = new SampleSourceBlock();

    //     let isImport = true;
    //     let isHtml = false;
    //     let isCS = false;

    //     let sampleCodeLines = sampleSourceCode.split('\n');
    //     for (const line of sampleCodeLines) {
    //         // if (line.indexOf(" from 'react'") > 0) continue;

    //         // skipping page routes because they will be auto-generated
    //         if (line.indexOf("@page") >= 0) continue;

    //         if (line.indexOf("<div") >= 0) {
    //             isImport = false; isHtml = true; isCS = false;
    //         }
    //         if (line.indexOf("@code") >= 0) {
    //             isImport = false; isHtml = false; isCS = true;
    //         }

    //         if (isCS) {
    //             sourceBlocks.CsharpCodeLines.push(line);
    //         } else if (isHtml) {
    //             sourceBlocks.HtmlCodeLines.push(line);
    //         } else if (isImport) {
    //             sourceBlocks.ImportLines.push(line);
    //         } else {
    //             sourceBlocks.OtherCodeLines.push(line);
    //         }

    //         // if (line.indexOf("import ") >= 0) {
    //         //     sample.ImportLines.push(line);
    //         //     // if (line.indexOf(" from ") === -1) continue;

    //         //     if (line.indexOf(" from ") > 0 && line.indexOf("./") === -1) {

    //         //         let importPackage = line.substring(line.indexOf("'") + 1, line.lastIndexOf("'"));
    //         //         if (importPackage === "") {
    //         //             importPackage = line.substring(line.indexOf('"') + 1, line.lastIndexOf('"'));
    //         //         }
    //         //         // console.log("<" + importPackage + ">");
    //         //         if (sample.ImportPackages.indexOf(importPackage) === -1) {
    //         //             sample.ImportPackages.push(importPackage);
    //         //         }
    //         //     } else if (line.indexOf(" from ") === -1) {
    //         //         sample.ImportCSS.push(line);

    //         //     } else if (line.indexOf("./") > 0 || line.indexOf("../") > 0) {
    //         //         sample.ImportFiles.push(line);
    //         //     }

    //         // } else {
    //         //     sample.OtherLines.push(line);
    //         // }
    //     }

    //     return sourceBlocks;
    // }

    public static getDependencies(sampleInfo: SampleInfo): PackageDependency[] {
        let dependencies: PackageDependency[] = [];
        let packageJson = sampleInfo.PackageFileContent;
        if (packageJson && packageJson.dependencies) {
            dependencies = [];

            let packages = packageJson.dependencies;

            for (let name in packages) {
                if (packages.hasOwnProperty(name)) {
                    let dependency = new PackageDependency();
                    dependency.name = name;
                    dependency.version = packages[name];
                    dependencies.push(dependency);
                    console.log(name + ": " + packages[name]);
                }
            }
        }
        return dependencies;
    }

    public static sort(samples: SampleInfo[]): void {
        samples.sort((a, b) => a.SampleFolderPath > b.SampleFolderPath ? 1 : -1);
    }

    public static printNames(samples: SampleInfo[]): void {
        for (const info of samples) {
            console.log(info.SampleFolderPath + " => " + info.SampleDisplayName);
        }
    }
    public static printRoutes(samples: SampleInfo[]): void {
        for (const info of samples) {
            console.log(info.SampleFolderPath + " => " + info.SampleRouteNew);
        }
    }
    public static printUrls(samples: SampleInfo[]): void {
        for (const info of samples) {
            console.log(info.SampleFolderPath + " => " + info.SandboxUrlEdit);
        }
    }

    public static getDataRoutes(samples: SampleInfo[]): void {
        // { name: 'tests', routes: [
        //     { path: '/tests/test-component1-test-sample0', name: 'SampleFileName', component: SampleFileName},
        //     { path: '/tests/test-component1-test-sample1', name: 'MapBindingDataJSON', component: MapBindingDataJSON},
        // ]},
    }


    public static process(samples: SampleInfo[]): void {

        for (const info of samples) {

            // ../samples/maps/geo-map/binding-csv-points
            // let relativePath = this.getRelative(SampleDirectory);
            // .., samples, maps, geo-map, binding-csv-points
            // console.log("pro SampleFolderPath " + info.SampleFolderPath);
            let folders = info.SampleFolderPath.split('/');

            if (folders.length > 3) info.ComponentGroup = folders[3];
            if (folders.length > 4) info.ComponentFolder = folders[4];
            if (folders.length > 5) info.SampleFolderName = folders[5];

            // console.log("pro ComponentFolder " + info.ComponentFolder);

            info.ComponentName = Strings.toTitleCase(info.ComponentFolder, '-');
            info.ComponentName = info.ComponentName.replace("Geo Map", "Geographic Map");
            info.ComponentName = info.ComponentName.replace("Combobox", "ComboBox");

            // info.SampleFolderPath = relativePath;
            info.SampleRouteOld = "/" +  info.ComponentGroup + "/" + info.ComponentFolder + "-" + info.SampleFolderName;
            info.SampleRouteNew = "/" +  info.ComponentGroup + "/" + info.ComponentFolder + "/" + info.SampleFolderName;

            // console.log("pro " + info.SampleFolderPath + " >> " + info.SampleRouteNew);

            let razorFiles: SampleFile[] = [];
            // finding .razor files in Pages folder
            for (const file of info.SourceFiles) {
                if (//Strings.includes(file.Path, igConfig.SamplesFolderName) &&
                    Strings.includes(file.Path, "App.razor") &&
                    Strings.includes(file.Path, igConfig.SamplesFileExtension) &&
                    Strings.excludes(file.Path, igConfig.SamplesFileExclusions, true)) {
                        razorFiles.push(file);
                        // console.log("pro name: " + file.Path);
                    // console.log(filePath);
                }
            }

            // checking if we have only one .razor file in Pages folder
            if (razorFiles.length === 0) {
                info.IsComplete = false;
                console.log("WARNING Transformer cannot match any " + igConfig.SamplesFileExtension + " files in sample: " + info.SampleFolderPath);
                for (const file of info.SourceFiles) {
                    console.log('- ' + file.Path);
                }
            } else if (razorFiles.length > 1) {
                info.IsComplete = false;
                console.log("WARNING Transformer cannot decide which " + igConfig.SamplesFileExtension + " file to use for sample name: ");
                console.log(" - " + razorFiles.join("\n - "));
            } else { // good we have only one .razor file per sample
                info.IsComplete = true;
                info.SourceRazorFile = new SampleSourceFile(razorFiles[0], info.ProgramModules);
                info.SampleFileName = info.SourceRazorFile.Name;
                // this.lintSample(info);

                // info.SourceRazorFile.LocalPath = "./Pages/" + info.SampleFileName;
                // info.SourceRazorFile.Blocks = this.getSampleBlocks(info.SourceRazorFile.Content);
                // auto-generating routing paths for a sample with and without SB navigation
                // info.SourceRazorFile.Blocks.ImportLines.splice(0, 0, "@page /samples" + info.SampleRouteNew);
                // info.SourceRazorFile.Blocks.ImportLines.splice(1, 0, "@page         " + info.SampleRouteNew);
                // info.SourceRazorFile.Blocks.ImportLines.splice(2, 0, "");

                // info.SampleFilePath = fileNames[0];
                // info.SampleFileName = this.getFileName(info.SampleFilePath);
                // info.SourceFileSourcePath = "./Pages/" + info.SampleFileName;
                // info.SourceFileSourceCode = transFS.readFileSync(info.SampleFilePath, "utf8");

                // console.log("pro code: \n" + info.SourceFileSourceCode);

                // info.SampleImportLines = sampleBlocks.ImportLines;
                // info.SampleImportFiles = sampleBlocks.ImportFiles;
                // info.SampleImportPackages = sampleBlocks.ImportPackages;


                // console.log("pro ==============================");
                // console.log("pro ImportLines:\n" + info.SourceRazorFile.Blocks.ImportLines.join('\n'));
                // console.log("pro ==============================");
                // console.log("pro HtmlCodeLines:\n" + info.SourceFileSourceBlock.HtmlCodeLines.join('\n'));
                // console.log("pro ==============================");
                // console.log("pro CsharpCodeLines:\n" + info.SourceFileSourceBlock.CsharpCodeLines.join('\n'));
                // console.log("pro ==============================");
                // console.log("pro OtherCodeLines:\n" + info.SourceFileSourceBlock.OtherCodeLines.join('\n'));
                // console.log("pro ==============================");

                // info.SampleImportName = info.SampleFileName.replace('.razor','');
                // info.SampleImportPath = './' + info.ComponentFolder + '/' + info.SampleFolderName + '/' + info.SampleImportName;

                info.SampleDisplayName = info.SampleFolderName;
                // info.SampleDisplayName = info.ComponentFolder + "" + info.SampleFolderName;
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "-", " ");
                info.SampleDisplayName = Strings.toTitleCase(info.SampleDisplayName);
                // info.SampleDisplayName = Strings.splitCamel(info.SampleFileName)
                // info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, igConfig.SamplesFileExtension, "");
                // info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Map Type ", "");
                // info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Map Binding ", "Binding ");
                // info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Map Display ", "Display ");
                // info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Data Chart Type ", "");
                // info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, info.ComponentName + " ", "");
                // console.log("pro SampleDisplayName: " + info.SampleDisplayName + " file=" + info.SampleFileName);

                info.SandboxUrlView = this.getSandboxUrl(info, igConfig.SandboxUrlView);
                info.SandboxUrlEdit = this.getSandboxUrl(info, igConfig.SandboxUrlEdit);
                info.SandboxUrlShort = this.getSandboxUrl(info, igConfig.SandboxUrlShort);

                info.DocsUrl = this.getDocsUrl(info);
                // console.log("SAMPLE " + info.SampleFilePath + " => " + info.SampleDisplayName);
            }

            // console.log(info.SampleFolderPath + " => " + info.SampleRouteNew + " => " + info.SampleDisplayName);

        }
    }

    public static verify(samples: SampleInfo[]): void {

        let comparedFiles: string[] = [];

        for (const sampleA of samples) {

            for (const fileA of sampleA.SourceFiles) {
                if (fileA.Name.indexOf("Program.cs") >= 0) continue;
                if (fileA.Name.indexOf(".razor") > 0) continue;
                if (comparedFiles.includes(fileA.Name)) continue;

                for (const sampleB of samples) {
                    if (sampleA.SampleFolderName == sampleB.SampleFolderName) continue;

                    for (const fileB of sampleB.SourceFiles) {
                        if (fileA.Name != fileB.Name) continue; // different file names

                        let contentA = transFS.readFileSync(fileA.Path).toString().trim();
                        let contentB = transFS.readFileSync(fileB.Path).toString().trim();

                        if (contentA !== contentB) {
                            console.log('WARNING: File "' + fileA.Name + '" has different content in these locations: \n' + fileA.Path + '\n' + fileB.Path)
                        }

                    }
                }
                comparedFiles.push(fileA.Name);
            }

        }
    }

    public static getSandboxUrl(sampleInfo: SampleInfo, sandboxUrlFormat: string): string {
        let url = sandboxUrlFormat + "";

        url = Strings.replaceAll(url, "{SandboxUrlOptions}", igConfig.SandboxUrlOptions);
        url = Strings.replaceAll(url, "{RepositoryPath}", igConfig.RepositoryPath);
        url = Strings.replaceAll(url, "{RepositoryOrg}", igConfig.RepositoryOrg);
        url = Strings.replaceAll(url, "{RepositoryName}", igConfig.RepositoryName);
        url = Strings.replaceAll(url, "{RepositoryBranch}", igConfig.RepositoryBranch);
        url = Strings.replaceAll(url, "{ComponentGroup}", sampleInfo.ComponentGroup);
        url = Strings.replaceAll(url, "{ComponentFolder}", sampleInfo.ComponentFolder);
        url = Strings.replaceAll(url, "{SampleFolderName}", sampleInfo.SampleFolderName);
        url = Strings.replaceAll(url, "{SampleFile}", sampleInfo.SampleFileName);

        return url;
    }

    public static getDocsUrl(sampleInfo: SampleInfo): string {
        let url = igConfig.DocsUrl + "";

        url = Strings.replaceAll(url, "{PlatformName}", igConfig.PlatformName);
        url = Strings.replaceAll(url, "{ComponentFolder}", sampleInfo.ComponentFolder);

        return url;
    }

    public static updateProject(projectFile: SampleFile): string {

        if (projectFile.Content === undefined) {
            console.log("reading " + projectFile.Path);
            projectFile.Content = transFS.readFileSync(projectFile.Path, "utf8");
        }
        let lines = projectFile.Content.split('\n');
        for (let line of lines) {

            for (let pack of igConfig.PackageReferences) {
                if (Strings.contains(line, pack.Name)) {
                    line = '    <PackageReference Include="' + pack.Name + '" Version="' + pack.Version + '" />'
                    console.log("updating " + projectFile.Path + " with " + pack.Name);
                    break;
                }
            }
        }

        let content = lines.join('\n');
        return content;
    }

    public static updatePackage(browsersPackage: PackageJson, templatePackage: PackageJson): string {

        let errors: string[] = [];

        // if (browsersPackage.author !== templatePackage.author)
        // errors.push("author", "does not match author in browser's package.json");

        // checking if the template has same dependencies as the browser
        for (let name in browsersPackage.dependencies) {
            if (templatePackage.dependencies.hasOwnProperty(name) &&
                browsersPackage.dependencies.hasOwnProperty(name)) {
                let browsersDep = browsersPackage.dependencies[name];
                let templateDep = templatePackage.dependencies[name];
                if (templateDep !== browsersDep) {
                    if (name.indexOf('igniteui-') === 0) {
                        browsersPackage.dependencies[name] = templateDep;
                        console.log("- changed browser's package " + name + " from " + browsersDep + " to " + templateDep);
                    } else {
                        errors.push("- template's package.json has \"" + name + "\" with \"" + templateDep + "\" while \"" + browsersDep + "\" is in browser's package.json");
                    }
                }
            }
        }

        // checking if the browser has same dependencies as the template
        // for (let name in templatePackage.dependencies) {
        //     if (templatePackage.dependencies.hasOwnProperty(name) &&
        //         browsersPackage.dependencies.hasOwnProperty(name)) {
        //         let browsersDep = browsersPackage.dependencies[name];
        //         let templateDep = templatePackage.dependencies[name];
        //         if (templateDep !== browsersDep) {
        //             errors.push("- browser's package.json has \"" + name + "\" with \"" + browsersDep + "\" while \"" + templateDep + "\" in template's package.json");
        //         }
        //     }
        // }

        if (errors.length > 0) {
            console.log("ERRORS found in package.json files: \n" + errors.join('\n'))
        }

        return JSON.stringify(browsersPackage, null, '  ');
    }


    public static getSampleInfo(sampleFile: any, sampleFilePaths?: string[]): SampleInfo {

        let info = new SampleInfo();
        info.SampleFolderPath = this.getRelative(sampleFile.dirname);
        // info.SampleFilePaths  = sampleFilePaths;
        // info.PackageFileContent = JSON.parse(sampleFile.contents.toString());
        // info.SampleFileSourceCode = sampleFile.contents.toString();

        for (const filePath of sampleFilePaths) {
            let parts = filePath.split('/');
            let file = new SampleFile();
            file.Path = filePath;
            file.Name = parts[parts.length - 1];
            file.Parent = parts[parts.length - 2];

            if (file.isRazorFile() ||
                file.isRazorComponent() ||
                file.isCS() ||
                file.isHTML() ||
                file.isPublicCSS() ||
                file.isPublicJS() ) {
                file.Content = transFS.readFileSync(filePath, "utf8");
                // console.log("pro file " + file.Path + "   " + file.Name);
            }

            if (file.isRazorFile()) {
                info.SourceFiles.splice(0, 0, file);

            } else if (file.isRazorComponent()) {
                info.SourceFiles.push(file);

            } else if (file.isCS()) {

                info.SourceFiles.push(file);

                if (file.Path.endsWith("Program.cs")) {
                    // getting IG modules from Program.cs
                    info.ProgramModules = [];
                    var lines = file.Content.split("\r\n");
                    for (const line of lines) {
                        var moduleIndex = line.indexOf("typeof(")
                        if (moduleIndex >= 0) {
                            var module = line;
                            module = module.replace("builder.Services.AddScoped(","");
                            module = module.replace("builder.Services.AddIgniteUIBlazor(","");
                            module = module.replace("typeof(IIgniteUIBlazor","");
                            module = module.replace("typeof(IgniteUIBlazor","");
                            module = module.replace("typeof(","");
                            module = module.split("(").join("");
                            module = module.split(")").join("");
                            module = module.replace(";","");
                            module = module.replace(",","");
                            module = module.trim();
                            if (module !== "") {
                                info.ProgramModules.push(module);
                            }
                        }
                    }
                    // console.log("info.ProgramModules \n" + info.ProgramModules.join("\n"));
                }
                // else {
                //     info.SourceFiles.push(file);
                // }

            } else if (file.isPublicCSS()) {
                // console.log("got PublicFiles_CSS=" + file.Path);
                info.PublicFiles_CSS.push(file);

            } else if (file.isPublicJS()) {
                info.PublicFiles_JS.push(file);

            } else if (file.Name.indexOf(".csproj") > 0) {
                info.ProjectFile = file;

            } else if (file.Name.indexOf("index.html") >= 0) {
                info.PublicIndexFile = file;
            }
            // info.SourceFiles.push(file);
            // info.SampleFileNames.push(parts[parts.length - 1]);
        }
        return info;
    }

    public static getRelative(path: string): string {
        // let path = filePath;
        if (path.indexOf(igConfig.RepositoryName) > -1) {
            path = path.split(igConfig.RepositoryName).pop() as string;
            path = path.split("\\").join("/");
            // return "." + path;
            return "../.." + path;
            // return path;
        }

        console.log("failed on getRelative " + path);
        return path;
    }

    public static getFileName(relativePath: string): string {
        // ./samples/maps/geo-map/display-esri-imagery/src/FileName.razor
        let parts = relativePath.split("/");
        if (parts.length > 0) {
            return parts[parts.length - 1]; // FileName.razor
        }
        console.log("failed on getFileName " + relativePath);
        return "";
    }

    public static getSourcePath(relativePath: string): string {
        // ./samples/maps/geo-map/display-esri-imagery/src/FileName.razor
        let parts = relativePath.split("/src");
        if (parts.length > 0) {
            return "./src" + parts[parts.length - 1]; // ./src/FileName.razor
        }
        console.log("failed on getSourcePath " + relativePath);
        return "";
    }

    public static getParent(path: string): string {
        const folders = path.split('\\');
        if (folders.length > 1) {
            return folders[folders.length  - 1];
        }
        return "";
    }

    public static updateIndex(sample: SampleInfo, template: string): string {

        let content = template + "";

        content = Strings.replaceAll(content, "SampleFileName", sample.SampleFileName);
        content = Strings.replaceAll(content, ".razor", "");
        return content;
    }


    // generates content of readme file for a given sample based on provided template of readme file
    public static updateReadme(sample: SampleInfo, template: string): string {

        // let ComponentGroup = "maps";
        // let ComponentFolder = "geo-map";
        // let SampleFolderName = "binding-csv-points";
        // let sampleFile = "MapBindingDataCSV.razor";

        let readMe = template + "";
        // replacing variables with values that were generated while processing each sample:
        readMe = Strings.replaceAll(readMe, "{SandboxUrlView}", sample.SandboxUrlView);
        readMe = Strings.replaceAll(readMe, "{SandboxUrlEdit}", sample.SandboxUrlEdit);

        readMe = Strings.replaceAll(readMe, "{ComponentFolder}", sample.ComponentFolder);
        readMe = Strings.replaceAll(readMe, "{ComponentGroup}", sample.ComponentGroup);
        readMe = Strings.replaceAll(readMe, "{ComponentName}", sample.ComponentName);

        // readMe = Strings.replaceAll(readMe, "{SampleFolderPath}", sample.SampleFolderPath);
        readMe = Strings.replaceAll(readMe, "{SampleFolderPath}", sample.SampleFolderPath);
        readMe = Strings.replaceAll(readMe, "{SampleFolderName}", sample.SampleFolderName);
        readMe = Strings.replaceAll(readMe, "{SampleRoute}", sample.SampleRouteNew);
        readMe = Strings.replaceAll(readMe, "{SampleDisplayName}", sample.SampleDisplayName);
        readMe = Strings.replaceAll(readMe, "{SampleFileName}", sample.SampleFileName);
        readMe = Strings.replaceAll(readMe, "{SampleFilePath}", sample.SampleFilePath);
        readMe = Strings.replaceAll(readMe, "{SampleFileSourcePath}", sample.SourceRazorFile.Path);
        readMe = Strings.replaceAll(readMe, "{SampleFileSourceCode}", sample.SourceRazorFile.Content);

        readMe = Strings.replaceAll(readMe, "{DocsUrl}", sample.DocsUrl);

        readMe = Strings.replaceAll(readMe, "{RepositoryWarning}", igConfig.RepositoryWarning);
        readMe = Strings.replaceAll(readMe, "{RepositoryUrl}", igConfig.RepositoryUrl);
        readMe = Strings.replaceAll(readMe, "{RepositoryPath}", igConfig.RepositoryPath);
        readMe = Strings.replaceAll(readMe, "{RepositoryBranch}", igConfig.RepositoryBranch);
        readMe = Strings.replaceAll(readMe, "{RepositoryOrg}", igConfig.RepositoryOrg);
        readMe = Strings.replaceAll(readMe, "{RepositoryName}", igConfig.RepositoryName);

        readMe = Strings.replaceAll(readMe, "{PlatformCode}", igConfig.PlatformCode);
        readMe = Strings.replaceAll(readMe, "{PlatformName}", igConfig.PlatformName);

        readMe = Strings.replaceAll(readMe, "{BrowserHostUrl}", igConfig.BrowserHostUrl);
        readMe = Strings.replaceAll(readMe, "{BrowserRootPath}", igConfig.BrowserRootPath);

        // console.log("====== ReadMe.md File =======================");
        // console.log(readMe);
        // console.log("====== ReadMe.md File =======================");
        return readMe;
    }

    public static getRoutingGroups(samples: SampleInfo[]): SampleGroup[] {
        let componentsMap = new Map<string, SampleComponent>();

        for (const sample of samples) {
            if (!sample.IsComplete) continue;

            if (componentsMap.has(sample.ComponentName)) {
                componentsMap.get(sample.ComponentName).Samples.push(sample);
            } else {
                let component = new SampleComponent();
                component.Name = sample.ComponentName;
                if (component.Name === "Data Grid") {
                    component.Group = "Other / Deprecated Components";
                    component.IsDeprecated = true;
                } else {
                    component.Group = sample.ComponentGroup;
                    component.IsDeprecated = false;
                }
                component.Samples.push(sample);
                componentsMap.set(sample.ComponentName, component);
            }
        }

        let groupMap = new Map<string, SampleGroup>();

        for (let key of Array.from( componentsMap.keys()) ) {
            let component = componentsMap.get(key);

            if (groupMap.has(component.Group)) {
                groupMap.get(component.Group).Components.push(component);
            } else {
                let group = new SampleGroup();
                group.Name = component.Group;
                group.IsDeprecated = component.IsDeprecated;
                group.Components.push(component);
                groupMap.set(component.Group, group);
            }
        }

        let groups: SampleGroup[] = [];
        for (let key of Array.from( groupMap.keys()) ) {
            let group = groupMap.get(key);
            group.Components = group.Components.sort(this.sortByComponentsName);

            for (let i = 0; i < group.Components.length; i++) {
                // const element = group.Components[i];
                group.Components[i].Samples = group.Components[i].Samples.sort(this.sortBySamplesName);
            }
            // console.log('group ' + key);
            // for (const component of group.Components) {
            //     console.log('component ' + component.name);

                // component.Samples = component.Samples.sort(this.sortBySamplesName);
            //     for (const sample of component.samples) {
            //         console.log('sample ' + sample.SampleFolderName);
            //     }
            // }
            // let group = new SampleGroup();
            // group.name = key;
            // group.samples = map.get(key);

            // for (let item of map.get(key) ) {
            //     console.log(item.SampleRouteNew);
            // }
            // // groups.push(map.get(key));
            groups.push(group);
        }

        var sortedGroups = groups.sort(this.sortByGroupName);

        var allGroups: SampleGroup[] = [];
        var deprecatedGroups: SampleGroup[] = [];
        for (const group of sortedGroups) {
            if (group.Name === "Other / Deprecated Components") {
                deprecatedGroups.push(group);
            } else {
                allGroups.push(group);
            }
        }

        for (const group of deprecatedGroups) {
            allGroups.push(group);
        }

        return allGroups;
    }

    public static sortByGroupName(a: any, b: any) {
        if (a.Name > b.Name) { return 1; }
        if (a.Name < b.Name) { return -1; }
        return 0;
    }

    public static sortByComponentsName(a: any, b: any) {
        if (a.Name > b.Name) { return 1; }
        if (a.Name < b.Name) { return -1; }
        return 0;
    }

    public static sortBySamplesName(a: any, b: any) {
        if (a.SampleDisplayName > b.SampleDisplayName) { return 1; }
        if (a.SampleDisplayName < b.SampleDisplayName) { return -1; }
        return 0;
    }

    public static tabs(times): string {
        return "  ".repeat(times);
    }

    public static getTocSample(info: SampleInfo): string {
        let toc = "";
        toc += this.tabs(6) + '{ "route": "' + info.SampleRouteOld + '", "name": "' + info.SampleDisplayName + '", "showLink": false },\n';
        toc += this.tabs(6) + '{ "route": "' + info.SampleRouteNew + '", "name": "' + info.SampleDisplayName + '", "showLink": true }';
        return toc;
    }

    public static getTocComponent(component: SampleComponent): string {
        let toc = '';
        toc += this.tabs(4) + '{\n';
        toc += this.tabs(5) + '"name": "' + component.Name + '", \n';
        toc += this.tabs(5) + '"samples": [ \n';

        for (let i = 0; i < component.Samples.length; i++) {
            const sample = component.Samples[i];
            toc += '' + this.getTocSample(sample);
            if (i < component.Samples.length - 1) toc += ','
            toc += '\n'
        }
        toc += this.tabs(5) + '] \n';
        toc += this.tabs(4) + '}'
        return toc;
    }

    public static getTocGroup(group: SampleGroup): string {
        let toc = '';
        toc += this.tabs(2) + '{\n';
        toc += this.tabs(3) + '"name": "' + Strings.toTitleCase(group.Name) + '", \n';
        toc += this.tabs(3) + '"components": [ \n';

        for (let i = 0; i < group.Components.length; i++) {
            const component = group.Components[i];
            toc += '' + this.getTocComponent(component);
            if (i < group.Components.length - 1) toc += ','
            toc += '\n'
        }

        toc += this.tabs(3) + '] \n';
        // toc += this.tabs(3) + '], \n';
        toc += this.tabs(2) + '}'
        return toc;
    }

    public static getRoutingFile(groups: SampleGroup[]): string {

        let toc = '{\n';

        toc += this.tabs(1) + '"groups": [ \n';
        for (let i = 0; i < groups.length; i++) {
            const group = groups[i];
            toc += this.getTocGroup(group);
            if (i < groups.length - 1) toc += ","
            toc += "\n"
        }

        toc += this.tabs(1) + '] \n';
        toc += "}"
        // console.log("================== TOC =============== ");
        // console.log(toc);
        return toc;
    }

    // lints all source files in a given sample and generates routing paths in .razor file
    public static lintSample(info: SampleInfo, generateRoutingPath?: boolean) {

        for (let i = 0; i < info.SourceFiles.length; i++) {
            let file = info.SourceFiles[i];

            // console.log("NOTE: lintSample() " + file.Path);

            let orgContent = file.Content;
            if (file.isRazorFile()) {
                // console.log("NOTE: lintRazor() " + file.Path);
                this.lintRazor(info, generateRoutingPath);
                this.lintFile(file);
            } else if (file.isRazorComponent()) {
                // this.lintRazor(info, false);
                this.lintFile(file);
            } else{
                this.lintFile(file);
            }

            if (file.Content !== orgContent) {
                file.IsChanged = true;
                // console.log("NOTE: lintSample() changed " + file.Path);
                // console.log("NOTE: lintSample() changed \n" + file.Content);
            }
            // else {
            //     // console.log("NOTE: lintSample() not changed \n" + file.Content);
            // }
        }
    }

    // lints .razor file in a given sample and generates routing paths (@page) for it
    public static lintRazor(sample: SampleInfo, generateRoutingPath?: boolean) {

        if (sample.SourceRazorFile === undefined ||
            sample.SourceRazorFile.Content === undefined) {
            return;
        }

        let invalidLines: string[] = [
            "@page ", // always remove page routing because it is auto-generated
            "base.OnInitialized",
        ];

        // removing injection of JSRuntime if a sample is not using JSRuntime
        if (sample.SourceRazorFile.Content.indexOf('JSRuntime.') === -1){
            invalidLines.push("@inject IJSRuntime JSRuntime");
        }

        let csharpCodeLines: string[] = [];
        let htmlCodeLines: string[] = [];
        let importLines: string[] = [];
        let otherLines: string[] = [];

        let isImport = true;
        let isHtml = false;
        let isCS = false;

        let fileLines = sample.SourceRazorFile.Content.split('\n');
        for (const line of fileLines) {
            // if (line.indexOf(" from 'react'") > 0) continue;

            // skipping lines with invalid/not needed keywords/code
            let isInvalidLine = false;
            for (const invalid of invalidLines) {
                if (line.indexOf(invalid) >= 0) {
                    isInvalidLine = true;
                    break;
                }
            }
            if (isInvalidLine) continue;

            if (line.indexOf("<div") >= 0 && isCS == false) {
                isImport = false; isHtml = true; isCS = false;
            }
            if (line.indexOf("@code") >= 0) {
                isImport = false; isHtml = false; isCS = true;
            }

            if (isCS) {
                csharpCodeLines.push(line);
            } else if (isHtml) {
                htmlCodeLines.push(line);
            } else if (isImport) {
                importLines.push(line.trim());
            } else {
                otherLines.push(line);
            }
        }

        if (otherLines.length > 0) {
            console.log("WARNING: lintRazor() failed in " + sample.SourceRazorFile.Path + " on line: " + otherLines[0]);
        }
        // if (csharpCodeLines.length === 0) {
        //     console.log("WARNING: lintRazor() found no CS code in " + sample.SourceRazorFile.Path);
        // }
        // if (htmlCodeLines.length === 0) {
        //     console.log("WARNING: lintRazor() found no HTML code in " + sample.SourceRazorFile.Path);
        // }
        // if (importLines.length === 0) {
        //     console.log("WARNING: lintRazor() found no @using/@inject statements in " + sample.SourceRazorFile.Path);
        // }

        let stylingLines: string[] = [];
        if (generateRoutingPath) {
            // console.log("lintRazor generateRoutingPath")
            // generating routing paths (@page) for a sample with and without SB navigation
            importLines.splice(0, 0, '@page "/samples' + sample.SampleRouteNew + '"');
            importLines.splice(1, 0, '@page "/samples' + sample.SampleRouteOld + '"');
            importLines.splice(2, 0, '@page         "' + sample.SampleRouteNew + '"');
            importLines.splice(3, 0, '@page         "' + sample.SampleRouteOld + '"');
            importLines.splice(4, 0, '');
            // console.log("NOTE: lintRazor() importLines \n" + importLines.join('\n'));

            var defaultCSS: string = "/*\n";
            defaultCSS += "CSS styles are loaded from the shared CSS file located at:\n"
            defaultCSS += "https://static.infragistics.com/xplatform/css/samples/\n"
            defaultCSS += "*/";

            if (sample.PublicFiles_CSS && sample.PublicFiles_CSS.length > 0) {
                // injecting CSS files as inline styles
                for (const css of sample.PublicFiles_CSS) {
                    let cssContent = css.Content.split('\n\n').join('\n').trim();
                    let cssLines = cssContent.split('\n');
                    if (cssLines.length <= 5 && cssContent.includes("CSS styles are loaded from the shared")) {
                        continue;
                    }

                    if (cssContent !== defaultCSS) {
                        // console.log("GULP injecting \n" + cssContent)
                        console.log("GULP injecting CSS from " + css.Path)
                        stylingLines.push('<style>');
                        stylingLines.push(cssContent);
                        stylingLines.push('</style>');
                    }
                }
            }
        }

        let newContent = importLines.join('\n') + '\n';
        if (stylingLines.length > 0)  {
            newContent += stylingLines.join('\n') + '\n';
        }
        newContent += htmlCodeLines.join('\n') + '\n';
        newContent += csharpCodeLines.join('\n') + '\n';

        sample.SourceFiles[0].Content = newContent;
        sample.SourceRazorFile.Content = newContent;

        this.lintFile(sample.SourceRazorFile);
    }

    public static lintFile(file: SampleFile) {
        let firstLine = true;
        let validLines: string[] = [];
        let fileLines = file.Content.split("\n");
        let spacedSymbols: string[] = ['(\\+)', '(\\*)', '(\{)', '(\})']; // '(\<)', '(\>)',  '(\=)',

        for (let i = 0; i < fileLines.length; i++) {
            let currentLine = fileLines[i].trimRight();
            let nextLine = i === fileLines.length - 1 ? '' : fileLines[i + 1].trimRight();

            // if (currentLine !== '' && nextLine !== '') {
            //     validLines.push(currentLine);
            // }
            if (currentLine === '' && firstLine) { continue; }
            if (currentLine === '' && nextLine === '') { continue; }

            if (currentLine.indexOf('@page') >= 0) {
                firstLine = false;
                validLines.push(currentLine);
                continue;
            }

            currentLine = Strings.replaceAll(currentLine, ';;', ';');
            if (currentLine.indexOf('"') === -1 &&
                currentLine.indexOf('//') === -1) {

                if (currentLine.indexOf('igc-') === -1 &&
                    currentLine.indexOf(':') === -1)
                {
                    for (const symbol of spacedSymbols) {
                        currentLine = currentLine.replace(new RegExp('([A-Za-z0-9])' + symbol), '$1 $2');
                        currentLine = currentLine.replace(new RegExp(symbol + '([A-Za-z0-9])'), '$1 $2');
                        // currentLine = currentLine.replace('/([a-z0-9])(\=)/g', '$1 $2');
                        // currentLine = currentLine.replace(new RegExp('([a-z0-9])(\=)'), '$1 $2');
                        // currentLine = currentLine.replace(/([a-z0-9])(\=)/gi, '_');
                    }
                }
                // currentLine = currentLine.replace(new RegExp('(using)([A-Za-z0-9])(;)'), '$1 $2');
                currentLine = currentLine.replace(new RegExp('(@using\.*.*)(\;)'), '$1');
                currentLine = currentLine.replace(new RegExp('(@inject\.*.*)(\;)'), '$1');

                currentLine = currentLine.replace(new RegExp('(for\.*.*)([A-Za-z0-9])(\=)'), '$1$2 $3');
                currentLine = currentLine.replace(new RegExp('(for\.*.*)([A-Za-z0-9])(\<)'), '$1$2 $3');
                currentLine = currentLine.replace(new RegExp('(for\.*.*)([A-Za-z0-9])(\>)'), '$1$2 $3');

                currentLine = currentLine.replace(new RegExp('(for\.*.*)(\=)([A-Za-z0-9])'), '$1$2 $3');
                currentLine = currentLine.replace(new RegExp('(for\.*.*)(\<)([A-Za-z0-9])'), '$1$2 $3');
                currentLine = currentLine.replace(new RegExp('(for\.*.*)(\>)([A-Za-z0-9])'), '$1$2 $3');
                currentLine = currentLine.replace(new RegExp('(for\.*.*)(\;)([A-Za-z0-9])'), '$1$2 $3');
                currentLine = currentLine.replace(new RegExp('(for\.*.*)(\;)([A-Za-z0-9])'), '$1$2 $3');

                currentLine = currentLine.replace(new RegExp('(for)(\\()(\.*.*)'), '$1 $2$3');
                // currentLine = currentLine.replace(new RegExp("(for\.*.*)(\\()(\.*.*)"), '$1$2$3');

                currentLine = Strings.replaceAll(currentLine, ' ++', '++');
                currentLine = Strings.replaceAll(currentLine, '"- ', '"-');
                currentLine = Strings.replaceAll(currentLine, '(- ', '(-');
                currentLine = Strings.replaceAll(currentLine, 'linear - gradient', 'linear-gradient');

            }

            currentLine = Strings.replaceAll(currentLine, 'className', 'class');

            // if (Strings.contains(currentLine, "for")){
            //     console.log('linting >>>> ' + currentLine);
            // }
            // console.log('linting ' + currentLine);

            firstLine = false;
            validLines.push(currentLine);

            // if (i === fileLines.length - 1)
            //     validLines.push(nextLine);
        }

        // importLines = importLines.sort();
        file.Content = validLines.join('\n');

        // console.log('======================================================');
        // console.log(importLines.join('\n') + '\n\n' + sourceLines.join('\n'));
        // console.log(validLines.join('\n'));
        // console.log('======================================================');
        // console.log('linting ' + fileLocation + ' done');
        // callback(null, vfile.toString());
        // callback(null, lintedContent);
        // return lintedContent;
    }
}


class Strings {

    public static contains(str: string, pattern: string): boolean {
        return str.indexOf(pattern) >= 0;
    }

    public static excludes(str: string, exclusions: string[], useEndsWith?: boolean): boolean {
        for (const exclusion of exclusions) {
            if (useEndsWith) {
                if (str.endsWith(exclusion)) { return false; }
            } else {
                if (str.includes(exclusion)) { return false; }
            }
        }
        return true;
    }

    public static includes(str: string, pattern: string): boolean {
        return str.includes(pattern);
    }

    public static replaceAll(orgStr: string, oldStr: string, newStr: string): string {
        return orgStr.split(oldStr).join(newStr);
    }

    public static toTitleCase(str: string, separator?: string) {
        if (separator === undefined) { separator = ' '; }
        return str.toLowerCase().split(separator).map(function(word) {
          return (word.charAt(0).toUpperCase() + word.slice(1));
        }).join(' ');
      }

    public static splitCamel(orgStr: string): string {
        if (orgStr === undefined) return "";
        return orgStr.replace(/([a-z0-9])([A-Z])/g, '$1 $2');
    }

    // .replace(/([a-z0-9])([A-Z])/g, '$1 $2')
    //   .split(/(?=[A-Z])/) v

}

class PackageJson {
    public name?: string;
    public description?: string;
    public author?: string;
    public homepage?: string;
    public version?: string;
    public private?: boolean;
    public scripts: any;
    public dependencies: any;
    public dependenciesOptional: any;
    public devDependencies: any;
    public browserslist?: string[];
}

class PackageDependency {
    public name: string;
    public version: string;

    public samples?: SampleInfo[];

    constructor() {
        this.samples = [];
    }

    public toString() : string {
        return '"' + this.name + `": "` + this.version + '"';
    }
}

// used in updateCodeViewer script to serialize JSON files
class CodeViewer {
    public path: string;
    public hasRelativeAssetsUrls: Boolean;
    public content: string;
    public isMain: Boolean;
    public fileExtension: string;
    public fileHeader: string;

    constructor(filePath: string, content: string, fileExtension: string, fileHeader: string, isMain: Boolean) {

        var jsonContent = content;
        // jsonContent = jsonContent.replace(/\/\//g, "/");

        this.hasRelativeAssetsUrls = false;
        this.path = filePath;
        this.content = jsonContent;
        this.isMain = isMain;
        this.fileExtension = fileExtension;
        this.fileHeader = fileHeader;
    }
}