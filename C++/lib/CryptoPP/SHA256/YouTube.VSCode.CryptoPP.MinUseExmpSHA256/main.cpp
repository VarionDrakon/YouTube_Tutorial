#include "lib/CryptoPP/sha.h"
#include "lib/CryptoPP/hex.h"
#include "lib/CryptoPP/files.h"
#include <filesystem>
#include <iostream>
#include <ostream>
#include <string>
#include <vector>

std::string calculateHash(const std::string& filePath){
    std::string hash;
    CryptoPP::SHA256 sha256;
    std::ifstream file(filePath, std::ios::binary);

    if(!file){
        std::cerr << "Not file or not could be read file" << std::endl;
        return nullptr; // Undesirable.
    }

    CryptoPP::FileSource calculateHashSum(file, true, 
        new CryptoPP::HashFilter(sha256, 
            new CryptoPP::HexEncoder(
                new CryptoPP::StringSink(hash)
            )
        )
    );

    file.close();
    return hash;
}

int main() {
    std::string pathFolder = "E:/TempFilesProgramm/OSSS/TempFolder/rename_factions";
    std::vector<std::string> vectorFilesPath;

    if(std::filesystem::exists(pathFolder)){
        for(const auto& entry : std::filesystem::recursive_directory_iterator(pathFolder)){
            const auto& path = entry.path();

            if(!std::filesystem::is_directory(path)){
                vectorFilesPath.push_back(path.string()); // Add path to files in the vector `vectorFilesPath`.
            }
        }

        for(const auto& filePath : vectorFilesPath){
            std::string calculate = calculateHash(filePath);

            if(!calculate.empty()){
                std::cout <<  "Hash for file: " << calculate << " & " << " File: " << filePath << std::endl; // Enumeration path from vector to console.
            }
            else{
                std::cerr << "Error calculate hash for file: " << filePath << std::endl;
            }
        }
    }
    else {
        std::cerr << "Path not exist!" << std::endl;
    }
   
    return 0;
}

